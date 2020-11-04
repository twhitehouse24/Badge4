using GuildCars.Data;
using GuildCars.Data.ADO;
using GuildCars.Data.Factories;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace GuildCars.Tests.Tests
{
    [TestFixture]
    public class ADO_Test
    {

        [SetUp]
        public void Setup()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GuildCars_Reset", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.ExecuteNonQuery();

                DirectoryInfo di = new DirectoryInfo("C:\\GuildCars\\GuildCars.UI\\GuildCars.UI\\images\\");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                string destinationDirectory = "C:\\GuildCars\\GuildCars.UI\\GuildCars.UI\\images\\";
                string file1ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-1.png";
                string file2ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-2.png";
                string file3ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-3.png";
                string file4ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-4.png";
                string file5ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-5.png";
                string file6ToCopy = "C:\\GuildCars\\SourceImages\\Inventory-6.png";

                System.IO.File.Copy(file1ToCopy, destinationDirectory + "Inventory-1.png");
                System.IO.File.Copy(file2ToCopy, destinationDirectory + "Inventory-2.png");
                System.IO.File.Copy(file3ToCopy, destinationDirectory + "Inventory-3.png");
                System.IO.File.Copy(file4ToCopy, destinationDirectory + "Inventory-4.png");
                System.IO.File.Copy(file5ToCopy, destinationDirectory + "Inventory-5.png");
                System.IO.File.Copy(file6ToCopy, destinationDirectory + "Inventory-6.png");
            }
        }

        [Test]
        public void ADO_Specials()
        {
            var repo = new SpecialsRepoADO();
            var specials = repo.GetSpecials();
            var special = specials[0];

            Assert.AreEqual(6, specials.Count());
            Assert.AreEqual("Special 1", special.Title);
            Assert.AreEqual("/images/Inventory-1.png", special.ImageFileName);

        }
        [Test]
        public void ADO_Featured()
        {
            var repo = new CarRepoADO();
            var featureds = repo.GetFeatured();
            var featured = featureds[0];

            Assert.AreEqual(6, featureds.Count());
            Assert.AreEqual("2017", featured.Year);
            Assert.AreEqual("/images/Inventory-1.png", featured.Photo_Path);
            Assert.AreEqual("Ford", featured.MakeName);
            Assert.AreEqual("F-150", featured.ModelName);
        }

        [Test]
        public void ADO_Years()
        {
            var repo = new CarRepoADO();
            var years = repo.GetYears();
            var yearMax = years[0];
            var yearMin = years[years.Count()-1];
            var tYear = DateTime.Now;
            var nYear = tYear.AddYears(+1).Year;
            //var fYear = tYear.AddYears(years.Count() - 1);
            Assert.AreEqual(22, years.Count());
            Assert.AreEqual(2000, yearMin.Year_Value);
            Assert.AreEqual(nYear, yearMax.Year_Value);
        }
        [Test]
        public void ADO_SearchAllCars()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "",
                MinPrice = "0",
                MaxPrice = "200000",
                MinYear = "0",
                MaxYear = "3000",
                Type = 3
            };

            var result = repo.SearchAllCars(searchCriteria).ToList();

            Assert.AreEqual(6, result.Count());

            //searchCriteria.SearchTerm = "";
            //searchCriteria.MinPrice = "29000";
            //searchCriteria.MaxPrice = "40000";
            //searchCriteria.MinYear = "2014";
            //searchCriteria.MaxYear = "2019";
            //searchCriteria.Type = 3;

            //result = repo.SearchAllCars(searchCriteria).ToList();

            //Assert.AreEqual(3, result.Count());

        }
        [Test]
        public void ADO_SearchAllCars_20000_40000_2014_2019()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "",
                MinPrice = "29000",
                MaxPrice = "40000",
                MinYear = "2014",
                MaxYear = "2019",
                Type = 3
            };


            var result = repo.SearchAllCars(searchCriteria).ToList();

            Assert.AreEqual(3, result.Count());

        }
        [Test]
        public void ADO_SearchAllCars_2021()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "",
                MinPrice = "0",
                MaxPrice = "200000",
                MinYear = "2021",
                MaxYear = "2021",
                Type = 3
            };
            var result = repo.SearchAllCars(searchCriteria).ToList();
            Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void ADO_SearchAllCars_Fo()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "Fo",
                MinPrice = "0",
                MaxPrice = "200000",
                MinYear = "0",
                MaxYear = "3000",
                Type = 3
            };
            var result = repo.SearchAllCars(searchCriteria).ToList();
            Assert.AreEqual(2, result.Count());
        }
        [Test]
        public void ADO_SearchNewCars()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "",
                MinPrice = "0",
                MaxPrice = "200000",
                MinYear = "0",
                MaxYear = "3000",
                Type = 1
            };
            var result = repo.SearchAllCars(searchCriteria).ToList();
            Assert.AreEqual(4, result.Count());
        }
        [Test]
        public void ADO_SearchUsedCars()
        {
            var repo = new CarRepoADO();
            SearchCriteria searchCriteria = new SearchCriteria
            {
                SearchTerm = "",
                MinPrice = "0",
                MaxPrice = "200000",
                MinYear = "0",
                MaxYear = "3000",
                Type = 2
            };
            var result = repo.SearchAllCars(searchCriteria).ToList();
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public void ADO_GetVehicleDetail()
        {
            var repo = new CarRepoADO();
            var car = repo.GetDetails(1);

            Assert.AreEqual(1, car.CarId);
            Assert.AreEqual(2, car.Type);
            Assert.AreEqual("2017", car.Year);
            Assert.AreEqual(false, car.Sold);
        }
        [Test]
        public void ADO_BodyStyles()
        {
            var repo = new BodyStylesRepoADO();
            var bodyStyles = repo.GetBodyStyles().ToList();
            Assert.AreEqual(4, bodyStyles.Count());
            Assert.AreEqual("Car", bodyStyles[0].BodyStyleDesc);
            Assert.AreEqual("Van", bodyStyles[3].BodyStyleDesc);
        }
        [Test]
        public void ADO_InteriorColors()
        {
            var repo = new IntColorsRepoADO();
            var intColors = repo.GetIntColors().ToList();
            Assert.AreEqual(6, intColors.Count());
            Assert.AreEqual("Grey", intColors[0].IntColorDesc);
            Assert.AreEqual("Tan", intColors[3].IntColorDesc);
        }
        [Test]
        public void ADO_ExteriorColors()
        {
            var repo = new ExtColorsRepoADO();
            var extColors = repo.GetExtColors().ToList();
            Assert.AreEqual(10, extColors.Count());
            Assert.AreEqual("White", extColors[0].ExtColorDesc);
            Assert.AreEqual("Gold", extColors[3].ExtColorDesc);
        }
        [Test]
        public void ADO_States()
        {
            var repo = new StatesRepo();
            var states = repo.GetStates().ToList();
            Assert.AreEqual(50, states.Count());
            Assert.AreEqual("KY", states[16].State_Abbrev);
            Assert.AreEqual("MN", states[22].State_Abbrev);
        }
        [Test]
        public void ADO_Makes()
        {
            var repo = new MakeRepoADO();
            var makes = repo.GetMakes().ToList();
            Assert.AreEqual(3, makes.Count());
            Assert.AreEqual("Ford", makes[0].MakeName);
            Assert.AreEqual("Toyota", makes[1].MakeName);
        }
        [Test]
        public void ADO_Models()
        {
            var repo = new ModelRepoADO();
            var models = repo.GetModels().ToList();
            Assert.AreEqual(6, models.Count());
            Assert.AreEqual("F-150", models[0].ModelName);
        }
        [Test, Order(1)]
        public void ADO_AddSpecial()
        {
            var repo = new SpecialsRepoADO();

            var special = new Specials();

            special.Title = "Special T";
            special.Description = "Special Text";

            repo.AddSpecial(special);


            var specials_List = repo.GetSpecials();
            var newspecial = specials_List[6];

            Assert.AreEqual(7, specials_List.Count());

        }
        [Test, Order(2)]
        public void ADO_DeleteSpecial()
        {
            var repo = new SpecialsRepoADO();

            var special = new Specials();

            special.Title = "Special T";
            var specials_List = repo.GetSpecials().ToList();

            var id = specials_List[specials_List.Count()-1].ID;

            repo.DeleteSpecial(id.ToString());

            specials_List = repo.GetSpecials().ToList();

            Assert.AreNotEqual(8, specials_List.Count());
            //Assert.AreNotEqual("Special T", special.Title);
            //Assert.AreNotEqual("Special Text", special.Description);
        }


    }
}