using GuildCars.Data.Interfaces;
using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using GuildCars.UI.Models;
using GuildCars.UI.Models.Ajax;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace GuildCars.Data
{
    public class CarRepoADO : ICarRepository
    {

        public List<Cars> GetAll()
        {
            List<Cars> cars = new List<Cars>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetAllCars", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cars currentRow = new Cars();

                        currentRow.CarId = (int)dr["CarId"];
                        currentRow.CarYr= (string)dr["Year"];
                        currentRow.Make = (string)dr["Make"];
                        currentRow.Model = (string)dr["Model"];
                        currentRow.BodyStyle = (string)dr["BodyStyle"];
                        currentRow.Trans = (string)dr["Trans"];
                        currentRow.IntColor = (string)dr["IntColor"];
                        currentRow.ExtColor = (string)dr["ExtColor"];
                        currentRow.CarMileage = (int)dr["Mileage"];
                        currentRow.VIN = (string)dr["Vin"];
                        currentRow.SalePrice = (decimal)dr["SalePrice"];
                        currentRow.MSRP = (decimal)dr["MSRP"];
                        currentRow.CarDescription = (string)dr["Description"];
                        currentRow.PhotoPath = (string)dr["Photo_Path"];
                        
                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }
        public List<Cars> SearchAllCars(string searchTerm, int minPrice, int maxPrice, int minYear, int maxYear, int Type)
        {
            List<Cars> cars = new List<Cars>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_SearchAllCars", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                cmd.Parameters.AddWithValue("@MinPrice", minPrice);
                cmd.Parameters.AddWithValue("@MaxPrice", maxPrice);
                cmd.Parameters.AddWithValue("@MinYear", minYear);
                cmd.Parameters.AddWithValue("@MaxYear", maxYear);
                cmd.Parameters.AddWithValue("@Type", Type);


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cars currentRow = new Cars();

                        currentRow.CarId = (int)dr["CarId"];
                        currentRow.CarYr = (string)dr["Year"];
                        currentRow.Make = (string)dr["Make"];
                        currentRow.Model = (string)dr["Model"];
                        currentRow.BodyStyle = (string)dr["BodyStyle"];
                        currentRow.Trans = (string)dr["Trans"];
                        currentRow.IntColor = (string)dr["IntColor"];
                        currentRow.ExtColor = (string)dr["ExtColor"];
                        currentRow.CarMileage = (int)dr["Mileage"];
                        currentRow.VIN = (string)dr["Vin"];
                        currentRow.SalePrice = (decimal)dr["SalePrice"];
                        currentRow.MSRP = (decimal)dr["MSRP"];
                        currentRow.CarDescription = (string)dr["Description"];
                        currentRow.PhotoPath = (string)dr["Photo_Path"];

                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }


        public IEnumerable<CarDetailViewModel> SearchAllCars(SearchCriteria searchCriteria)
        {
            List<CarDetailViewModel> cars = new List<CarDetailViewModel>();



            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_SearchAllCars", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@searchTerm", searchCriteria.SearchTerm);
                cmd.Parameters.AddWithValue("@MinPrice", searchCriteria.MinPrice);
                cmd.Parameters.AddWithValue("@MaxPrice", searchCriteria.MaxPrice);
                cmd.Parameters.AddWithValue("@MinYear", searchCriteria.MinYear);
                cmd.Parameters.AddWithValue("@MaxYear", searchCriteria.MaxYear);
                cmd.Parameters.AddWithValue("@Type", searchCriteria.Type);


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        CarDetailViewModel currentRow = new CarDetailViewModel();

                        currentRow.CarId = (int)dr["CarId"];
                        currentRow.Year = (string)dr["Year"];
                        currentRow.Make = (string)dr["Make"];
                        currentRow.Model = (string)dr["Model"];
                        currentRow.BodyStyle = (string)dr["BodyStyle"];
                        currentRow.Transmission = (string)dr["Trans"];
                       // currentRow.IntColor = (string)dr["IntColor"];
                       //-currentRow.ExtColor = (string)dr["ExtColor"];
                        currentRow.Mileage = (int)dr["Mileage"];
                        currentRow.VIN = (string)dr["Vin"];
                        currentRow.SalePrice = (decimal)dr["SalePrice"];
                        currentRow.MSRP = (decimal)dr["MSRP"];
                        currentRow.Description = (string)dr["Description"];
                        currentRow.Photo_Path = (string)dr["Photo_Path"];

                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }



        public List<GetFeatured> GetFeatured()
        {
            List<GetFeatured> featuredCars = new List<GetFeatured>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("usp_GetFeatured", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        GetFeatured currentRow = new GetFeatured();

                        currentRow.CarId = (int)dr["CarId"];
                        currentRow.Year = (string)dr["Year"];
                        currentRow.Photo_Path = (string)dr["Photo_Path"];
                        currentRow.MakeName = (string)dr["MakeName"];
                        currentRow.ModelName = (string)dr["ModelName"];
                        currentRow.SalePrice = (decimal)dr["SalePrice"];

                        featuredCars.Add(currentRow);
                    }
                }
            }
            return featuredCars;
        }
        public ListItem GetDetails(int id)
        {
            ListItem listitem = null;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetDetails", cn);
               //cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        listitem = new ListItem();

                        listitem.CarId = (int)dr["CarId"];
                        listitem.Year = (string)dr["Year"];
                        listitem.Make = (string)dr["Make"];
                        listitem.Type = (int)dr["Type"];
                        listitem.Model = (string)dr["Model"];
                        listitem.BodyStyle = (string)dr["BodyStyle"];
                        listitem.Transmission = (string)dr["Trans"];
                        listitem.IntColor = (string)dr["IntColor"];
                        listitem.ExtColor = (string)dr["ExtColor"];
                        listitem.Mileage = (int)dr["Mileage"];
                        listitem.Vin = (string)dr["Vin"];
                        listitem.SalePrice = (decimal)dr["SalePrice"];
                        listitem.Msrp = (decimal)dr["MSRP"];
                        listitem.Description = (string)dr["Description"];
                        listitem.Photo_Path = (string)dr["Photo_Path"];
                        listitem.Sold = (bool)dr["Sold"];

                    }
                }
            }
            return listitem;
        }

        public void AddNewCar(Cars cars)
        {
     
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_AddNewCar", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.Parameters.AddWithValue("@MakeId", cars.MakeId);
                cmd.Parameters.AddWithValue("@ModelId", cars.ModelId);
                cmd.Parameters.AddWithValue("@Type", cars.CarType);
                cmd.Parameters.AddWithValue("@BodyStyle", cars.BodyStyle);
                cmd.Parameters.AddWithValue("@Yr", cars.CarYr);
                cmd.Parameters.AddWithValue("@Trans", cars.CarTrans);
                cmd.Parameters.AddWithValue("@ExtColor", cars.ExtColor);
                cmd.Parameters.AddWithValue("@IntColor", cars.IntColor);
                cmd.Parameters.AddWithValue("@Mileage", cars.CarMileage);
                cmd.Parameters.AddWithValue("@Vin", cars.VIN);
                cmd.Parameters.AddWithValue("@Msrp", cars.MSRP);
                cmd.Parameters.AddWithValue("@SalePrice", cars.SalePrice);
                cmd.Parameters.AddWithValue("@Desc", cars.CarDescription);
                cmd.Parameters.AddWithValue("@ImageName", cars.CarImageName);

                cmd.ExecuteNonQuery();

            }
        }

        public Cars GetVehicleById(int id)
        {
            Cars cars = null;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetVehicleById", cn);
                //cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cars = new Cars();

                        cars.CarId = (int)dr["CarId"];
                        cars.ModelId = (int)dr["ModelId"];
                        cars.MakeId = (int)dr["MakeId"];
                        cars.CarYr = (string)dr["CarYr"];
                        cars.CarType = (int)dr["CarType"];
                        cars.BodyStyle = (string)dr["CarBodyStyle"];
                        cars.MSRP = (decimal)dr["MSRP"];
                        cars.SalePrice = (decimal)dr["SalePrice"];
                        cars.VIN = (string)dr["VIN"];
                        cars.CarTrans = (int)dr["CarTrans"];
                        cars.ExtColor = (string)dr["ExtColor"];
                        cars.IntColor = (string)dr["IntColor"];
                        cars.CarMileage = (int)dr["Mileage"];
                        cars.CarDescription = (string)dr["Desc"];
                        cars.CarPhoto = (string)dr["PhotoPath"];
                        cars.IsFeatured = (bool)dr["IsFeatured"];

                    }
                }
            }
            return cars;
        }

        public void UpdateVehicle(Cars cars)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_UpdateVehicle", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.Parameters.AddWithValue("@CarId", cars.CarId);
                cmd.Parameters.AddWithValue("@MakeId", cars.MakeId);
                cmd.Parameters.AddWithValue("@ModelId", cars.ModelId);
                cmd.Parameters.AddWithValue("@CarType", cars.CarType);
                cmd.Parameters.AddWithValue("@BodyStyle", cars.BodyStyle);
                cmd.Parameters.AddWithValue("@Yr", cars.CarYr);
                cmd.Parameters.AddWithValue("@CarTrans", cars.CarTrans);
                cmd.Parameters.AddWithValue("@ExtColor", cars.ExtColor);
                cmd.Parameters.AddWithValue("@IntColor", cars.IntColor);
                cmd.Parameters.AddWithValue("@Mileage", cars.CarMileage);
                cmd.Parameters.AddWithValue("@VIN", cars.VIN);
                cmd.Parameters.AddWithValue("@MSRP", cars.MSRP);
                cmd.Parameters.AddWithValue("@SalePrice", cars.SalePrice);
                cmd.Parameters.AddWithValue("@Desc", cars.CarDescription);
                cmd.Parameters.AddWithValue("@PhotoPath", cars.PhotoPath);
                cmd.Parameters.AddWithValue("@IsFeatured", cars.IsFeatured);
                cmd.ExecuteNonQuery();

            }
        }
        public IEnumerable<CarDetailViewModel> SearchForNew(Search search)
        {

            var cars = GetAll();

            var carSearch = (from c in cars
                              select new CarDetailViewModel
                              {
                                  CarId = c.CarId,
                                  Year = c.CarYr,
                                  Make = c.Make,
                                  Model = c.Model,
                                  BodyStyle = c.BodyStyle,
                                  Transmission = "1",
                                  Mileage = c.CarMileage,
                                  VIN = c.VIN,
                                  SalePrice = c.SalePrice,
                                  MSRP = c.MSRP,
                                  Description = c.CarDescription
                                                                                                                                                                                             
                              }).Take(20).ToList();

            return carSearch;

        }

        public List<Cars> GetNewList()  // For Inventory
        {
            List<Cars> cars = new List<Cars>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("[usp_NewInventoryCars]", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cars currentRow = new Cars();
                        currentRow.CarYr = (string)dr["Year"];
                        currentRow.Make = (string)dr["Make"];
                        currentRow.Model = (string)dr["Model"];
                        currentRow.Count = (int)dr["Count"];
                        currentRow.MSRP = (decimal)dr["MSRP"];
                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }
        public List<Cars> GetUsedList()  // For Inventory
        {
            List<Cars> cars = new List<Cars>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("[usp_UsedInventoryCars]", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cars currentRow = new Cars();
                        currentRow.CarYr = (string)dr["Year"];
                        currentRow.Make = (string)dr["Make"];
                        currentRow.Model = (string)dr["Model"];
                        currentRow.Count = (int)dr["Count"];
                        currentRow.MSRP = (decimal)dr["MSRP"];
                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }
        public List<Years> GetYears()
        {


            List<Years> yearsList = new List<Years>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetYears", cn);
                //cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Years currentrow = new Years();

                        currentrow.Year_Value = (int)dr["Year_Value"];
                        yearsList.Add(currentrow);


                    }
                }
            }
            return yearsList;

        }
        public List<Users> GetSalesUsers()  
        {
            List<Users> users = new List<Users>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("[usp_GetSalesUsers]", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Users currentRow = new Users();
                        currentRow.UserName = (string)dr["UserName"];
                        users.Add(currentRow);
                    }
                }
            }
            return users;
        }

        //Reports
        public List<Users> GetSalesResults(string searchUser, DateTime fromDate, DateTime toDate)  
        {
            string format = "M-d-yyyy";
            List<Users> users = new List<Users>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;



                SqlCommand cmd = new SqlCommand("[usp_GetSalesResults]", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", searchUser);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.ToString(format));
                cmd.Parameters.AddWithValue("@ToDate", toDate.ToString(format));
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Users currentRow = new Users();
                        currentRow.UserName = (string)dr["User"];
                        currentRow.CountOfCarsSold = (int)dr["CountOfCarsSold"];
                        currentRow.TotalSales = (decimal)dr["TotalSales"];
                        users.Add(currentRow);
                    }
                }
            }
            return users;
        }

        public void AddPurchase(PurchaseVehicleViewModel pv)
        {
            
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("[usp_NewPurchase]", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.Parameters.AddWithValue("@UserName", pv.UserName);
                cmd.Parameters.AddWithValue("@CustName", pv.CustName);
                cmd.Parameters.AddWithValue("@CustPhone", pv.CustPhone);
                cmd.Parameters.AddWithValue("@CustEmail", pv.CustEmail);
                cmd.Parameters.AddWithValue("@CustStreet1", pv.CustStreet1);
                cmd.Parameters.AddWithValue("@CustStreet2", pv.CustStreet2);
                cmd.Parameters.AddWithValue("@CustCity", pv.CustCity);
                cmd.Parameters.AddWithValue("@CustState", pv.CustState);
                cmd.Parameters.AddWithValue("@CustZip", pv.CustZip);
                cmd.Parameters.AddWithValue("@SalePrice", pv.SalePrice);
                cmd.Parameters.AddWithValue("@PurchaseType", pv.PurchaseType);
                cmd.Parameters.AddWithValue("@CarId", pv.CarId);


                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteVehicle(string id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("usp_DeleteVehicle", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}