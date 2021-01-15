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
    public class TreatsController : Controller
    {
        private readonly PierreBakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public TreatsController(UserManager<ApplicationUser> userManager, PierreBakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Treats.ToList());
        }
    }
}