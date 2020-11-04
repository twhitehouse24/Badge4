using GuildCars.Data;
using GuildCars.Data.Factories;
using GuildCars.Models.ViewModels;
using GuildCars.UI.Models;
using System.Web.Mvc;

namespace GuildCars.UI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            FeaturedViewModel model = new FeaturedViewModel();

            //var repo = RepoFactory.GetRepo().GetFeatured();
            var repo = RepoFactory.GetRepo();
            var repos = SpecialsRepoFactory.GetRepo();


            model.GetFeatured = repo.GetFeatured();
            model.Specials = repos.GetSpecials();

            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Guild Cars";
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Specials()
        {
            var repo = SpecialsRepoFactory.GetRepo();
            return View(repo.GetSpecials());
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Contact()
        {
            
            var contactForm = new ContactFormViewModel { Message = "" };

            if (Request.QueryString["vin"] !=null)
            {
            contactForm = new ContactFormViewModel { Message = "VIN# " + Request.QueryString["vin"] };
            }
            return View(contactForm);


        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Contact(ContactFormViewModel contactForm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Contact us by phone or email.";
                var repo = ContactFormRepoFactory.GetRepo();
                repo.SubmitContactForm(contactForm);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

    }
}