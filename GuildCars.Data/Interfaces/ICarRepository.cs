using GuildCars.Models.Queries;
using GuildCars.UI.Models;
using System;
using System.Collections.Generic;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Interfaces
{
    public interface ICarRepository
    {

        List<Cars> GetAll();
        List<GetFeatured> GetFeatured();
        ListItem GetDetails(int CarId);

        void AddNewCar(Cars cars);
        Cars GetVehicleById(int id);
        void UpdateVehicle(Cars cars);

        List<Cars> SearchAllCars(string searchTerm, int minPrice, int maxPrice, int minYear, int maxYear, int Type);
        List<Cars> GetNewList();
        List<Cars> GetUsedList();
        List<Users> GetSalesResults(string searchUser, DateTime fromDate, DateTime toDate);
        List<Users> GetSalesUsers();


        void AddPurchase(PurchaseVehicleViewModel pv);
        List<Years> GetYears();
        void DeleteVehicle(string id);

    }
}