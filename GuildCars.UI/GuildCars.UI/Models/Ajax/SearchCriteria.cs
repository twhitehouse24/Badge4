using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.UI.Models.Ajax
{
    public class SearchCriteria
    {
        public string SearchTerm { get; set; }
        public string MinPrice { get; set; }
        public string MaxPrice { get; set; }
        public string MinYear { get; set; }
        public string MaxYear { get; set; }
        public int Type { get; set; }
    }
}