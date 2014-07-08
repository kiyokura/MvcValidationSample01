using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcValidationSample01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ModelState.AddModelError("foo", "error for foo 1");
            ModelState.AddModelError("foo", "error for foo 2");
            ModelState.AddModelError("bar", "error for bar");
            ModelState.AddModelError("hoge", "error for hoge");
            return View();
        }
    }
}