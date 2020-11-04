using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Queries
{
    public class GetSalesResults
    {
        public string UserName {get; set;}
        public int TotalSales { get; set; }
        public int CountOfCarsSold { get; set; }

    }
}