using GuildCars.Data;
using GuildCars.Data.Factories;
using GuildCars.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using GuildCars.UI.Models.Ajax;
using AcceptVerbsAttribute = System.Web.Http.AcceptVerbsAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace GuildCars.UI.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize(Roles = "Sales")]
        public ActionResult Sales()
        {
            var repo = RepoFactory.GetRepo();
            SalesReportViewModel model = new SalesReportViewModel();
            model.UserList = repo.GetSalesUsers();
            model.UDDList = new SelectList(repo.GetSalesUsers(), "UserName", "UserName");

            return View(model);
        }

        [HttpGet]
        //[Authorize(Roles = "Sales")]
        public ActionResult Inventory()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var repo = RepoFactory.GetRepo();
            InventoryViewModel model = new InventoryViewModel();

            model.NewList = repo.GetNewList();
            model.UsedList = repo.GetUsedList();

            return View(model);
        }
    }
}