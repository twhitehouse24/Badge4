using GuildCars.Data;
using GuildCars.Data.ADO;
using GuildCars.Data.Factories;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Tests.Tests
{
    [TestFixture]
    public class Mock_Test
    {
            [Test]
            public void Mock_Specials()
            {
                var repo = new SpecialsMockRepo();
                var specials = repo.GetSpecials();
                var special = specials[0];

                Assert.AreEqual(8, specials.Count());
                Assert.AreEqual("Special 1", special.Title);
                
            }
            [Test]
            public void Mock_Featured()
            {
                var repo = new CarMockRepo();
                var featureds = repo.GetFeatured();
                var featured = featureds[0];

                Assert.AreEqual(6, featureds.Count());
                Assert.AreEqual("2015", featured.CarYr);
                Assert.AreEqual("/images/FordExpedition.jpg", featured.Photo_Path);
                Assert.AreEqual("Ford", featured.Make);
                Assert.AreEqual("Expedition", featured.Model);
            }

            [Test]
            public void Mock_Years()
            {
                var repo = new YearsMockRepo();
                var years = repo.GetYears();
                var yearMax = years[0];
                var yearMin = years[years.Count() - 1];
                var tYear = DateTime.Now;
                var nYear = tYear.AddYears(+1).Year;
                //var fYear = tYear.AddYears(years.Count() - 1);
                Assert.AreEqual(22, years.Count());
                Assert.AreEqual(2000, yearMin.Year_Value);
                Assert.AreEqual(nYear, yearMax.Year_Value);
            }
            //[Test]
            //public void SearchAllCars()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "",
            //        MinPrice = "0",
            //        MaxPrice = "200000",
            //        MinYear = "0",
            //        MaxYear = "3000",
            //        Type = 3
            //    };

            //    var result = repo.SearchAllCars(searchCriteria).ToList();

            //    Assert.AreEqual(9, result.Count());

            //}
            //[Test]
            //public void SearchAllCars_20000_40000_2014_2019()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "",
            //        MinPrice = "29000",
            //        MaxPrice = "40000",
            //        MinYear = "2014",
            //        MaxYear = "2019",
            //        Type = 3
            //    };


            //    var result = repo.SearchAllCars(searchCriteria).ToList();

            //    Assert.AreEqual(3, result.Count());

            //}
            //[Test]
            //public void SearchAllCars_2021()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "",
            //        MinPrice = "0",
            //        MaxPrice = "200000",
            //        MinYear = "2021",
            //        MaxYear = "2021",
            //        Type = 3
            //    };
            //    var result = repo.SearchAllCars(searchCriteria).ToList();
            //    Assert.AreEqual(2, result.Count());
            //}
            //[Test]
            //public void SearchAllCars_Fo()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "Fo",
            //        MinPrice = "0",
            //        MaxPrice = "200000",
            //        MinYear = "0",
            //        MaxYear = "3000",
            //        Type = 3
            //    };
            //    var result = repo.SearchAllCars(searchCriteria).ToList();
            //    Assert.AreEqual(3, result.Count());
            //}
            //[Test]
            //public void SearchNewCars()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "",
            //        MinPrice = "0",
            //        MaxPrice = "200000",
            //        MinYear = "0",
            //        MaxYear = "3000",
            //        Type = 1
            //    };
            //    var result = repo.SearchAllCars(searchCriteria).ToList();
            //    Assert.AreEqual(6, result.Count());
            //}
            //[Test]
            //public void SearchUsedCars()
            //{
            //    var repo = new CarMockRepo();
            //    SearchCriteria searchCriteria = new SearchCriteria
            //    {
            //        SearchTerm = "",
            //        MinPrice = "0",
            //        MaxPrice = "200000",
            //        MinYear = "0",
            //        MaxYear = "3000",
            //        Type = 2
            //    };
            //    var result = repo.SearchAllCars(searchCriteria).ToList();
            //    Assert.AreEqual(3, result.Count());
            //}

            [Test]
            public void Mock_GetVehicleDetail()
            {
                var repo = new CarMockRepo();
                var car = repo.GetDetails(1);

                Assert.AreEqual(1, car.CarId);
                Assert.AreEqual(1, car.Type);
                Assert.AreEqual("2015", car.Year);
                Assert.AreEqual(false, car.Sold);
            }
            [Test]
            public void Mock_BodyStyles()
            {
                var repo = new BodyStyleMockRepo();
                var bodyStyles = repo.GetBodyStyles().ToList();
                Assert.AreEqual(4, bodyStyles.Count());
                Assert.AreEqual("Car", bodyStyles[0].BodyStyleDesc);
                Assert.AreEqual("Van", bodyStyles[3].BodyStyleDesc);
            }
            [Test]
            public void Mock_InteriorColors()
            {
                var repo = new IntColorsMockRepo();
                var intColors = repo.GetIntColors().ToList();
                Assert.AreEqual(6, intColors.Count());
                Assert.AreEqual("Grey", intColors[0].IntColorDesc);
                Assert.AreEqual("Tan", intColors[3].IntColorDesc);
            }
            [Test]
            public void Mock_ExteriorColors()
            {
                var repo = new ExtColorsMockRepo();
                var extColors = repo.GetExtColors().ToList();
                Assert.AreEqual(10, extColors.Count());
                Assert.AreEqual("White", extColors[0].ExtColorDesc);
                Assert.AreEqual("Gold", extColors[3].ExtColorDesc);
            }
            [Test]
            public void Mock_States()
            {
                var repo = new StatesMockRepo();
                var states = repo.GetStates().ToList();
                Assert.AreEqual(50, states.Count());
                Assert.AreEqual("KY", states[16].State_Abbrev);
                Assert.AreEqual("MN", states[22].State_Abbrev);
            }
            [Test]
            public void Mock_Makes()
            {
                var repo = new MakeMockRepo();
                var makes = repo.GetMakes().ToList();
                Assert.AreEqual(3, makes.Count());
                Assert.AreEqual("Ford", makes[0].MakeName);
                Assert.AreEqual("Toyota", makes[2].MakeName);
            }
            [Test]
            public void Mock_Models()
            {
                var repo = new ModelMockRepo();
                var models = repo.GetModels().ToList();
                Assert.AreEqual(4, models.Count());
                Assert.AreEqual("Escort", models[0].ModelName);
                Assert.AreEqual("Expedition", models[3].ModelName);
            }
            [Test, Order(1)]
            public void Mock_AddSpecial()
            {
                var repo = new SpecialsMockRepo();

                var special = new Specials();

                special.Title = "Special 9";
                special.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
                special.ImageFileName = "/Images/DefaultDesk_Style_COUPE.png";
                
                repo.AddSpecial(special);



                var specials_List = repo.GetSpecials();
                var newspecial = specials_List[8];

                Assert.AreEqual(9, specials_List.Count());
                Assert.AreEqual("Special 9", newspecial.Title);
                Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", newspecial.Description);
            }
            [Test, Order(2)]
            public void Mock_DeleteSpecial()
            {
                var repo = new SpecialsMockRepo();

                var special = new Specials();

                special.Title = "Special T";
                var specials_List = repo.GetSpecials().ToList();

                var id = specials_List[specials_List.Count() - 1].ID;

                repo.DeleteSpecial(id.ToString());

                specials_List = repo.GetSpecials().ToList();

                Assert.AreNotEqual(9, specials_List.Count());
                Assert.AreNotEqual("Special 9", special.Title);
                Assert.AreNotEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", special.Description);

        }
    }
}