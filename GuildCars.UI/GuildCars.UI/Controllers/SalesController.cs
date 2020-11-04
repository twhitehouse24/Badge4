using GuildCars.Data;
using GuildCars.Data.Factories;
using GuildCars.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace GuildCars.UI.Controllers
{
    public class SalesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult Purchase(int id)
        {
            StateViewModel model = new StateViewModel();
            var repo = RepoFactory.GetRepo();
            var strepo = StateRepoFactory.GetRepo();


            model.purchaseVehicleViewModel = new PurchaseVehicleViewModel();
            model.StateList = new SelectList(strepo.GetStates().ToList(), "State_Abbrev", "State_Abbrev");
            model.Listitem =  repo.GetDetails(id);
            

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Purchase(PurchaseVehicleViewModel model)
        {
            var repo = RepoFactory.GetRepo();


            PurchaseVehicleViewModel pv = new PurchaseVehicleViewModel();

            pv.UserName = User.Identity.GetUserName();
            pv.CustName = model.CustName; 
            pv.CustPhone = model.CustPhone;
            pv.CustEmail = model.CustEmail;
            pv.CustStreet1 = model.CustStreet1;
            pv.CustStreet2 = model.CustStreet2;
            pv.CustCity = model.CustCity;
            pv.CustState = model.State_Abbrev;
            pv.CustZip = model.CustZip;
            pv.SalePrice = model.SalePrice;
            pv.PurchaseType = model.PurchaseType;
            pv.CarId = model.CarId;

            if (ModelState.IsValid)
            {
                repo.AddPurchase(pv);

            return RedirectToAction("Index");
            }
            StateViewModel m = new StateViewModel();

            var strepo = StateRepoFactory.GetRepo();

            m.purchaseVehicleViewModel = pv;
            m.StateList = new SelectList(strepo.GetStates().ToList(), "State_Abbrev", "State_Abbrev");
            m.Listitem = repo.GetDetails(model.CarId);

            return View("Purchase",m);
        }
    }
}