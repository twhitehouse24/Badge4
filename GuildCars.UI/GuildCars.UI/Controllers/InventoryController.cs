using GuildCars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Controllers
{
    public class InventoryController : Controller
    {

        [HttpGet]
        [AllowAnonymous]
        public ActionResult New()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult Used()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            var repo = RepoFactory.GetRepo();
            return View(repo.GetDetails(id));
        }
    }
}