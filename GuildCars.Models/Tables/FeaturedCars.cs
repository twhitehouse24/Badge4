using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Tables
{
    public class FeaturedCars
    {

        public string Year { get; set; }
        public string Photo_Path { get; set; }
        public string Photo_Alt { get; set; }
        public string Make { get; set; }
        public decimal SalePrice { get; set; }
        public string Model { get; set; }

    }
}