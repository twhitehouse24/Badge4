using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.UI.Models
{
    public class ModelList
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public DateTime DateAdded { get; set; }
        public string MakeName { get; set; }
        public string UpdatedBy { get; set; }
    }
}