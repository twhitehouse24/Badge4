using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Queries
{
    public class ListItem
    {
        public int CarId { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyStyle { get; set; }
        public string Transmission { get; set; }
        public string IntColor { get; set; }
        public string ExtColor { get; set; }
        public int Mileage { get; set; }
        public string Vin { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Msrp { get; set; }
        public string Description { get; set; }
        public string Photo_Name { get; set; }
        public string Photo_Path { get; set; }
        public bool Sold { get; set; }
        public int Type { get; set; }

    }
}