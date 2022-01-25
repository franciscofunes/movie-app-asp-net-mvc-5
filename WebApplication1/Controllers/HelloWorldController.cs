using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult  Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(String name, int numTimes = 1)
        {
            ViewBag.Message = "hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}