using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Queries
{
    public class EditVehicle
    {

        public int Carid { get; set; }
        public int CarModelid { get; set; }
        public int CarMakeid { get; set; }
        public string CarYr { get; set; }
        public int CarType { get; set; }
        public string CarBodyStyle { get; set; }
        public decimal MSRP { get; set; }
        public decimal SalePrice { get; set; }
        public string Vin { get; set; }
        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public int CarTrans { get; set; }
        public int CarMileage { get; set; }
        public string CarDescription { get; set; }
        public string CarImageName { get; set; }
        public string CarPhoto { get; set; }



    }
}