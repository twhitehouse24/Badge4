using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.UI.Models
{
    public class FeaturedViewModel
    {
        public string Year { get; set; }
        public string Type { get; set; }
        public string Make { get; set; }
        public string SalePrice { get; set; }

        public List<Specials> Specials { get; set; }
        public IEnumerable<GetFeatured> GetFeatured { get; set; }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageFilesName { get; set; }


    }
}