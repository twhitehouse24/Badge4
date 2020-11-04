using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Queries
{
    public class GetFeatured
    {
        public int CarId { get; set; }
        public string Year { get; set; }
        public string Photo_Path { get; set; }
        public string Make { get; set; }
        public decimal SalePrice { get; set; }
        public string Model { get; set; }
        public bool IsFeatured { get; set; }
        public int FeaturedVehicle { get; set; }

        public string CarYr { get; set; }
        public int CarType { get; set; }
        public string CarBodyStyle { get; set; }
        public decimal MSRP { get; set; }
        public string VIN { get; set; }
        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public string Trans { get; set; }
        public int CarMileage { get; set; }
        public string CarDescription { get; set; }
        public string MakeName { get; set; }
        public string ModelName { get; set; }


        //public IEnumerable<Specials> Specials { get; set; }
        //public IEnumerable<FeaturedCars> Featured { get; set; }
    }
}