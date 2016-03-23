using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNFenwick_PetStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventory()
        {

            return View();
        }

        [Authorize]
        public ActionResult Manage()
        {
            return View();
        }
    }
}