using Microsoft.AspNetCore.Mvc;
using PierreBakery.Models;
using System.Collections.Generic;
using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierreBakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly PierreBakeryContext _db;
        public HomeController(PierreBakeryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            var flavors = _db.Flavors.ToList();
            var treats = _db.Treats.ToList();
            Dictionary<string, object> model = new Dictionary<string, object> {};
            model.Add("treat", treats);
            model.Add("flavor", flavors);
            return View(model);
        }
    }
}