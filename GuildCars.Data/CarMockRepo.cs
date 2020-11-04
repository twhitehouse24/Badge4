using GuildCars.Data.Interfaces;
using GuildCars.Models;
using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using GuildCars.UI.Models;
using GuildCars.UI.Models.Ajax;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace GuildCars.Data
{

    public class CarMockRepo : ICarRepository
    {
        private static List<Cars> _cars = new List<Cars>();

        static CarMockRepo()
        {
            _cars = new List<Cars>
            {
                new Cars
                {
                    CarId = 1,
                    CarYr = "2015",
                    Make = "Ford",
                    Model = "Expedition",
                    BodyStyle = "SUV",
                    Trans = "Automatic",
                    IntColor = "Grey",
                    ExtColor = "White",
                    CarMileage = 100,
                    VIN = "JT4RN61D8F5061251",
                    SalePrice = 49900,
                    MSRP = 65000,
                    CarDescription = "King Ranch",
                    PhotoPath = "/images/FordExpedition.jpg",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false
                },
                new Cars
                {
                    CarId = 2,
                    CarYr = "2017",
                    Make = "Ford",
                    Model = "F-150",
                    BodyStyle = "Truck",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Red",
                    CarMileage = 110,
                    VIN = "JT4RN61D8F5061252",
                    SalePrice = 75000,
                    MSRP = 80000,
                    CarDescription = "Lariat",
                    PhotoPath = "/images/DefaultDesk_Style_TRUCKS.png",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false
                },
                new Cars
                {
                    CarId = 3,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false
                },
                new Cars
                {
                    CarId = 4,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false
                },
                new Cars
                {
                    CarId = 5,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false

                },
                new Cars
                {
                    CarId = 6,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 1,
                    IsFeatured = true,
                    IsSpecial = true,
                    IsSold  = false
                },
                new Cars
                {
                    CarId = 7,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 2,
                    IsFeatured = false,
                    IsSpecial = true,
                    IsSold  = false
                },

                new Cars
                {
                    CarId = 8,
                    CarYr = "2018",
                    Make = "Ford",
                    Model = "Fusion",
                    BodyStyle = "Sedan",
                    Trans = "Manual",
                    IntColor = "Grey",
                    ExtColor = "Black",
                    CarMileage = 101,
                    VIN = "JT4RN61D8F5061253",
                    SalePrice = 45000,
                    MSRP = 50000,
                    CarDescription = "SE",
                    PhotoPath = "/images/Ford Fusion.jpg",
                    CarType = 2,
                    IsFeatured = false,
                    IsSpecial = true,
                    IsSold  = false
                },
            };
        }

 


        public List<GetFeatured> GetFeatured()
        {
            List<Cars> featuredCars = _cars.FindAll(c => c.IsFeatured == true);
            List<GetFeatured> getFeatured = new List<GetFeatured>();

            foreach (var c in featuredCars)
            {
                GetFeatured featuredCar = new GetFeatured
                {
                    CarId = c.CarId,
                    CarYr = c.CarYr,
                    Make = c.Make,
                    Model = c.Model,
                    SalePrice = 45000,
                    Photo_Path = c.PhotoPath
                };

                getFeatured.Add(featuredCar);
            }
            return getFeatured;
        }
        
        public ListItem GetDetails(int CarforSale_Id)
        {
            ListItem listitem = null;
            var car = _cars.FirstOrDefault(c => c.CarId == CarforSale_Id);

            listitem = new ListItem();
            listitem.CarId = car.CarId;
            listitem.Make = car.Make;
            listitem.Model = car.Model;
            listitem.Photo_Path = car.PhotoPath;
            listitem.BodyStyle = car.BodyStyle;
            listitem.IntColor = car.IntColor;
            listitem.ExtColor = car.ExtColor;
            listitem.SalePrice = car.SalePrice;
            listitem.Transmission = car.Trans;
            listitem.Mileage = car.CarMileage;
            listitem.Msrp = car.MSRP;
            listitem.Vin = car.VIN;
            listitem.Description = car.CarDescription;
            listitem.Type = car.CarType;
            listitem.Year = car.CarYr;
            listitem.Sold = car.CarSold;


            return listitem;
        }

        public void AddNewCar(Cars cars)
        {
            _cars.Add(cars);
        }

        public Cars GetVehicleById(int id)
        {
            Cars car = _cars.FirstOrDefault(c => c.CarId == id);

           
            car.CarId = car.CarId;
            car.Make = car.Make;
            car.Model = car.Model;
            car.PhotoPath = car.PhotoPath;
            car.BodyStyle = car.BodyStyle;
            car.IntColor = car.IntColor;
            car.ExtColor = car.ExtColor;
            car.SalePrice = car.SalePrice;
            car.CarTrans = car.CarTrans;
            car.CarMileage = car.CarMileage;
            car.MSRP = car.MSRP;
            car.VIN = car.VIN;
            car.CarDescription = car.CarDescription;

            return car;
        }

        public void UpdateVehicle(Cars cars)
        {

            Cars car = _cars.FirstOrDefault(c => c.CarId == cars.CarId);
            _cars.Remove(car);
            _cars.Add(cars);

        }

        public List<Cars> SearchAllCars(string searchTerm, int minPrice, int maxPrice, int minYear, int maxYear, int Type)
        {
            List<Cars> searchResults = new List<Cars>();


            if (Type ==3)
            {
                List<Cars> searchTerms = _cars.FindAll(c => c.Make.Contains(searchTerm));
                if (minPrice > 0)
                {
                    List<Cars> price = _cars.FindAll(c => 
                                                    (c.SalePrice > minPrice) && 
                                                    (c.SalePrice < maxPrice));
                }
                if (minYear > 0)
                {
                    List<Cars> year = _cars.FindAll(c =>
                                                    (Int32.Parse(c.CarYr) > minYear) &&
                                                    (Int32.Parse(c.CarYr) < maxYear));
                }
                foreach (var car in searchTerms)
                {
                    searchResults.Add(car);
                }
            }
            if (Type == 2)
            {
                List<Cars> searchTerms = _cars.FindAll(c =>
                                                      (c.Make.Contains(searchTerm)) &&
                                                      (c.CarType == 2));

                if (minPrice > 0)
                {
                    searchTerms = _cars.FindAll(c =>
                                                   (c.SalePrice > minPrice) &&
                                                   (c.SalePrice < maxPrice) &&
                                                   (c.CarType == 2));
                }
                if (minYear > 0)
                {
                    searchTerms = _cars.FindAll(c =>
                                                    (Int32.Parse(c.CarYr) > minYear) &&
                                                    (Int32.Parse(c.CarYr) < maxYear) &&
                                                    (c.CarType == 2));
                }
                foreach (var car in searchTerms)
                {
                    searchResults.Add(car);
                }
            }
            if (Type == 1)
            {
                List<Cars> searchTerms = _cars.FindAll(c =>
                                                      (c.Make.Contains(searchTerm)) &&
                                                      (c.CarType == 1));

                if (minPrice > 0)
                {
                    searchTerms = _cars.FindAll(c =>
                                                   (c.SalePrice > minPrice) &&
                                                   (c.SalePrice < maxPrice) &&
                                                   (c.CarType == 1));
                }
                if (minYear > 0)
                {
                    searchTerms = _cars.FindAll(c =>
                                                    (Int32.Parse(c.CarYr) > minYear) &&
                                                    (Int32.Parse(c.CarYr) < maxYear) &&
                                                    (c.CarType == 1));
                }
                foreach (var car in searchTerms)
                {
                    searchResults.Add(car);
                }
            }
            return searchResults;

            
        }

        public List<Cars> GetNewList()
        {
            List<Cars> newList = _cars.FindAll(c => c.CarType == 0);

            return newList;
        }

        public List<Cars> GetUsedList()
        {
            List<Cars> usedList = _cars.FindAll(c => c.CarType == 1);

            return usedList;
        }
        
        public List<Users> GetSalesResults()
        {
            throw new NotImplementedException();
        }
        
        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Users> GetSalesResults(string searchUser, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetSalesUsers()
        {
            throw new NotImplementedException();
        }

        public void AddPurchase(PurchaseVehicleViewModel pv)
        {
            throw new NotImplementedException();
        }

        public List<Years> GetYears()
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(string id)
        {
            throw new NotImplementedException();
        }
    }


    public class YearsMockRepo
    {
        public static List<Years> _modelYears = new List<Years>();

        static YearsMockRepo()
        {
            _modelYears = new List<Years>
            {
                new Years
                {
                    Year_Value = 2021,
                },
                new Years
                {
                    Year_Value = 2020,
                },
                new Years
                {
                    Year_Value = 2019,
                },
                new Years
                {
                    Year_Value = 2018,
                },
                new Years
                {
                    Year_Value = 2017,
                },
                new Years
                {
                    Year_Value = 2016,
                },
                new Years
                {
                    Year_Value = 2015,
                },
                new Years
                {
                    Year_Value = 2014,
                },
                new Years
                {
                    Year_Value = 2013,
                },
                new Years
                {
                    Year_Value = 2012,
                },
                new Years
                {
                    Year_Value = 2011,
                },
                new Years
                {
                    Year_Value = 2010,
                },
                new Years
                {
                    Year_Value = 2009,
                },
                new Years
                {
                    Year_Value = 2008,
                },
                new Years
                {
                    Year_Value = 2007,
                },
                new Years
                {
                    Year_Value = 2006,
                },
                new Years
                {
                    Year_Value = 2005,
                },
                new Years
                {
                    Year_Value = 2004,
                },
                new Years
                {
                    Year_Value = 2003,
                },
                new Years
                {
                    Year_Value = 2002,
                },
                new Years
                {
                    Year_Value = 2001,
                },
                new Years
                {
                    Year_Value = 2000,
                },

            };
        }




        public List<Years> GetYears()
        {
            return _modelYears;
        }
    }



}