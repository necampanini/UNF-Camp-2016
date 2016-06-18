using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static List<BlogEntry> entries = new List<BlogEntry>()
        {
            new BlogEntry() {
                Id = 1,
                Title = "Test 1",
                Body = "This is the 1st blog entry"
            },
            new BlogEntry() {
                Id = 2,
                Title = "Test 2",
                Body = "This is the 2nd blog entry"
            }
        };

        public ActionResult Index()
        {
            return View(entries);
        }

        public ActionResult Detail(int id)
        {
            var entry = entries.FirstOrDefault(i => i.Id == id);

            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogEntry model)
        {
            model.Id = entries.Count + 1;

            entries.Add(model);

            return Redirect("/");
        }
    }
}





