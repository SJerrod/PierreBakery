using PierreBakery.Models;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierreBakery.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly PierreBakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public FlavorsController(UserManager<ApplicationUser> userManager, PierreBakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Flavors.ToList());
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor, int TreatId)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            flavor.User = currentUser;
            _db.Flavors.Add(flavor);
            if (TreatId != 0)
            {
                _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId});
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisFlavor = _db.Flavors
                .Include(flavor => flavor.JoinEntries)
                .ThenInclude(join => join.Treat)
                .Include(flavor => flavor.User)
                .FirstOrDefault(flavor => flavor.FlavorId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null ? userId == thisFlavor.User.Id : false;
            return View(thisFlavor);
        }

        [Authorize]
        public async Task<ActionResult> Edit(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var thisFlavor = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(flavors => flavors.FlavorId == id);
            if (thisFlavor == null)
            {
                return RedirectToAction("Details", new {id = id});
            }
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name"); 
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult Edit(Flavor flavor, int TreatId)
        {
          if (TreatId != 0)
          {
            _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
          }
          _db.Entry(flavor).State = EntityState.Modified;
          _db.SaveChanges();
          return RedirectToAction("Index");
        }
    }
}