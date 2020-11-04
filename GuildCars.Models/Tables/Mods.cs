using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Tables
{
    public class Mods
    {
        public int ModelId { get; set; }

        [Required]
        public string ModelName { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public DateTime DateAdded { get; set; }
        public string UpdatedBy { get; set; }
        public string NewModel { get; set; }
    }
}