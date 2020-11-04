using GuildCars.Data;
using GuildCars.Models;
using GuildCars.UI.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using GuildCars.UI.Utilities;
using GuildCars.Models.Tables;
using GuildCars.Data.Factories;
using System.IO;

namespace GuildCars.UI.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Makes()
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            var repo = MakeRepoFactory.GetRepo();
            var makes = repo.GetMakes();

            return View(makes);
        }

        [HttpPost]
        public ActionResult Makes(Make model)
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            var repo = MakeRepoFactory.GetRepo();

            Make make = new Make();
            make.MakeName = model.NewMake;
            make.UpdatedBy = User.Identity.GetUserName();

            if (make.MakeName == null)
            {
                ViewBag.ErrorMessage = "Make name must be provided to save";
                var makes = repo.GetMakes();
                return View(makes);
            }
            else
            {
            repo.Insert(make);

            return RedirectToAction("Makes");
            }


        }
        [HttpGet]
        public ActionResult ManageModels()
        {
            ModelsViewModel model = new ModelsViewModel();
            var modelrepo = ModelRepoFactory.GetRepo();
            var makerepo = MakeRepoFactory.GetRepo();
            
            var models = modelrepo.GetModels();
            var makes = makerepo.GetMakes();

            model.Models = (from m in models 
                            select new ModelList
                            {
                                ModelName = m.ModelName,
                                DateAdded = m.DateAdded,
                                MakeName = m.MakeName,
                                UpdatedBy = m.UpdatedBy
                            }).ToList();


            model.Makes = new SelectList(makerepo.GetMakes(), "MakeName", "MakeName");
                                          
            return View(model);
        }
        [HttpPost]
        public ActionResult ManageModels(ModelsViewModel modelsViewModel)
        {
            var repo = ModelRepoFactory.GetRepo();
            var makerepo = MakeRepoFactory.GetRepo();

            var models = repo.GetModels();
            var makes = makerepo.GetMakes();

            Mods mods = new Mods();
            mods.ModelName = modelsViewModel.NewModel;
            mods.MakeName = modelsViewModel.MakeName;
            mods.UpdatedBy = User.Identity.GetUserName();

            ///-----------------------------------------------///

            modelsViewModel.Models = (from m in models
                            select new ModelList
                            {
                                ModelName = m.ModelName,
                                DateAdded = m.DateAdded,
                                MakeName = m.MakeName,
                                UpdatedBy = m.UpdatedBy
                            }).ToList();


            modelsViewModel.Makes = new SelectList(makerepo.GetMakes(), "MakeName", "MakeName");

            ///------------------------------------------------///

            if (mods.ModelName == null)
            {
                ViewBag.ErrorMessage = "Model name must be provided to save";
                modelsViewModel.Makes = new SelectList(makerepo.GetMakes(), "MakeName", "MakeName");
                return View(modelsViewModel);
            }
            else
            {
                repo.Insert(mods);
                return RedirectToAction("ManageModels");
            }
        }
        //[HttpPost]
        //public ActionResult ManageModels(Mods model)
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    var repo = ModelRepoFactory.GetRepo();

        //    Mods mods = new Mods();
        //    mods.ModelName = model.NewModel;
        //    mods.MakeName = model.MakeName;
        //    mods.UpdatedBy = User.Identity.GetUserName();


        //    if(mods.ModelName == null)
        //    {
        //        return View();

        //    }
        //    else
        //    {
        //    repo.Insert(mods);

        //    return RedirectToAction("ManageModels");
        //    }

        //}

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Users()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var repo = UserRepoFactory.GetRepo();
            var users = repo.GetUsers();
            return View(users);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AddUser()
        {
            return View();
        }

        public async Task<ActionResult> AddUser(AddUserViewModel model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var repo = UserRepoFactory.GetRepo();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //model.Password = "Welcome123";

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.users.FirstName.Substring(0, 1) + model.users.LastName, Email = model.users.Email, FirstName = model.users.FirstName, LastName = model.users.LastName,
                EmailConfirmed = Convert.ToBoolean(0), PhoneNumberConfirmed = Convert.ToBoolean(0), TwoFactorEnabled = Convert.ToBoolean(0), LockoutEnabled = Convert.ToBoolean(0), AccessFailedCount = 0, Level = 0, JoinDate = DateTime.Now };

            if (model.NewPassword1 != null && model.ConfirmPassword != null)
            {
                if (model.NewPassword1 != model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "New password and confirm password do not match");
                }
                else
                {
                    var result = await UserManager.CreateAsync(user, model.NewPassword1);
                }
            }
                model.users.RoleId = model.RoleId;
                repo.AddNewUser(model.users);

                return RedirectToAction("Users", "Admin");
            }
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult EditUser(string id)
        {
            EditUserViewModel model = new EditUserViewModel();
            var repo = UserRepoFactory.GetRepo();
            model.users = repo.GetUserById(id);
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult EditUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var repo = UserRepoFactory.GetRepo();
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var authManager = HttpContext.GetOwinContext().Authentication;

                try
                {  
                    if (model.NewPassword1 != null)
                    {
                        if (model.NewPassword1 != null && model.ConfirmPassword != null)
                        {
                            if (model.NewPassword1 != model.ConfirmPassword)
                            {
                                ModelState.AddModelError("", "New password and confirm password do not match");
                            }
                            else
                            {
                                userManager.RemovePassword(model.users.UserId);
                                userManager.AddPassword(model.users.UserId, model.NewPassword1);
                            }
                        }
                    }
                    model.users.RoleId = model.RoleId;
                    repo.UpdateUser(model.users);
                    return RedirectToAction("Users", "Admin");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Specials()
        {
            var repo = SpecialsRepoFactory.GetRepo();
            SpecialsViewModel model = new SpecialsViewModel();
            model.Specials  = repo.GetSpecials().ToList();
            //model.ddImageFileName = new SelectList(Data, "ImageFileName", "ImageFileName");

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Specials(Specials model)
        {

            var repo = SpecialsRepoFactory.GetRepo();
            Specials special = new Specials();
            special.Title = model.Title;
            special.Description = model.Description;

            repo.AddSpecial(special);

            return RedirectToAction("Specials", "Admin");

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteSpecial()
        {
            var deleteForm = new DeleteForm { ID = Request.QueryString["sid"], Title = Request.QueryString["t"] };
            return View(deleteForm);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteSpecial(DeleteForm deleteForm)
        {
            
            var repo = SpecialsRepoFactory.GetRepo();
            repo.DeleteSpecial(deleteForm.ID.ToString());
            return RedirectToAction("Specials", "Admin");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteVehicle()
        {
            var deleteVehicleForm = new DeleteVehicleForm { ID = Request.QueryString["sid"] };
            return View(deleteVehicleForm);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteVehicle(DeleteVehicleForm deleteVehicleForm)
        {
            var repo = RepoFactory.GetRepo();
            int NewID = Int32.Parse(deleteVehicleForm.ID);
            var img = repo.GetVehicleById(NewID);

            System.IO.File.Delete(@"C:\GuildCars\GuildCars.UI\GuildCars.UI\" + img.CarPhoto);


            repo.DeleteVehicle(deleteVehicleForm.ID.ToString());



            return RedirectToAction("Vehicles", "Admin");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AddVehicle()
        {
            AddVehicleViewModel model = new AddVehicleViewModel();
            var modelrepo = ModelRepoFactory.GetRepo();
            var makerepo = MakeRepoFactory.GetRepo();
            var repo = RepoFactory.GetRepo();
            var repoExt = ExtColorsRepoFactory.GetRepo();
            var repoInt = IntColorsRepoFactory.GetRepo();
            var repoBS = BodyStyleFactory.GetRepo();

            model.Makes = new SelectList(makerepo.GetMakes(), "MakeId", "MakeName");
            model.Models = new SelectList(modelrepo.GetFilteredModels("0"), "ModelId", "ModelName");
            model.ExteriorColors = new SelectList(repoExt.GetExtColors(), "ExtColorId", "ExtColorDesc");
            model.InteriorColors = new SelectList(repoInt.GetIntColors(), "ExtColorId", "ExtColorDesc");
            model.BodyStyles = new SelectList(repoBS.GetBodyStyles(), "BodyStyleId", "BodyStyleDesc");
            model.Years = new SelectList(repo.GetYears(), "Year_Value", "Year_Value");

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult AddVehicle(Cars model, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                var repo = RepoFactory.GetRepo();


            Cars cars = new Cars();

            cars.MakeId = model.MakeId;
            cars.ModelId = model.ModelId;
            cars.CarType = model.CarType;
            cars.BodyStyle = model.BodyStyle;
            cars.CarYr = model.CarYr;
            cars.CarTrans = model.CarTrans;
            cars.ExtColor = model.ExtColor;
            cars.IntColor = model.IntColor;
            cars.CarMileage = model.CarMileage;
            cars.VIN = model.VIN;
            cars.MSRP = model.MSRP;
            cars.SalePrice = model.SalePrice;
            cars.CarDescription = model.CarDescription;
            cars.CarImageName = model.CarImageName;


            repo.AddNewCar(cars);

             return RedirectToAction("Vehicles");
            }

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Vehicles()
        {
            var repo = RepoFactory.GetRepo();
            var cars = repo.GetAll().ToList();

            return View(cars);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult EditVehicle(int id)
        {
            EditVehicleViewModel model = new EditVehicleViewModel();

            var modelrepo = ModelRepoFactory.GetRepo();
            var makerepo = MakeRepoFactory.GetRepo();
            var repo = RepoFactory.GetRepo();
            var repoExt = ExtColorsRepoFactory.GetRepo();
            var repoInt = IntColorsRepoFactory.GetRepo();
            var repoBS = BodyStyleFactory.GetRepo();

            model.Makes = new SelectList(makerepo.GetMakes(), "MakeId", "MakeName");
            model.Models = new SelectList(modelrepo.GetModels(), "ModelId", "ModelName");
            model.ExteriorColors = new SelectList(repoExt.GetExtColors(), "ExtColorId", "ExtColorDesc");
            model.InteriorColors = new SelectList(repoInt.GetIntColors(), "IntColorId", "IntColorDesc");
            model.BodyStyles = new SelectList(repoBS.GetBodyStyles(), "BodyStyleId", "BodyStyleDesc");
            model.Years = new SelectList(repo.GetYears(), "Year_Value", "Year_Value");


            model.cars = repo.GetVehicleById(id);

            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult EditVehicle (EditVehicleViewModel model,HttpPostedFileBase postedFile)
        {
            var modelrepo = ModelRepoFactory.GetRepo();
            var makerepo = MakeRepoFactory.GetRepo();
            var repo = RepoFactory.GetRepo();
            var repoExt = ExtColorsRepoFactory.GetRepo();
            var repoInt = IntColorsRepoFactory.GetRepo();
            var repoBS = BodyStyleFactory.GetRepo();

            model.Makes = new SelectList(makerepo.GetMakes(), "MakeId", "MakeName");
            model.Models = new SelectList(modelrepo.GetModels(), "ModelId", "ModelName");
            model.ExteriorColors = new SelectList(repoExt.GetExtColors(), "ExtColorId", "ExtColorDesc");
            model.InteriorColors = new SelectList(repoInt.GetIntColors(), "IntColorId", "IntColorDesc");
            model.BodyStyles = new SelectList(repoBS.GetBodyStyles(), "BodyStyleId", "BodyStyleDesc");
            model.Years = new SelectList(repo.GetYears(), "Year_Value", "Year_Value");


            if (ModelState.IsValid)
            {
            if (model.postedFile!=null) 
            {
            string SaveLocation;
                    //string fn = System.IO.Path.GetFileName(postedFile.FileName);
                    string extn = Path.GetExtension(postedFile.FileName);
                    string fn = "Inventory-" + model.cars.CarId + extn;
                    

                    SaveLocation = Server.MapPath("/") + "images\\" + fn;
  
             model.postedFile.SaveAs(SaveLocation);

                    model.cars.PhotoPath = fn;

             //model.cars.PhotoPath = postedFile.FileName;

            }
            else
            {
                string imagetoupdate = model.cars.CarPhoto.Substring(0, 8);
                 if (!imagetoupdate.Contains("/images/"))
                {
                     int l = (model.cars.CarPhoto.Length)-1;
                    model.cars.CarPhoto = model.cars.CarPhoto.Substring(8,l-7);
                    string extn = Path.GetExtension(model.cars.CarPhoto);
                    model.cars.PhotoPath = "Inventory-" + model.cars.CarId + extn; 
                    model.cars.PhotoPath = model.cars.CarPhoto;
                }
                 else
                {
                    model.cars.PhotoPath = model.cars.CarPhoto;
                }
            }
            repo.UpdateVehicle(model.cars);
            return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
    }
}