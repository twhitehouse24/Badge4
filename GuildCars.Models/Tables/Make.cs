using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Tables
{
    public class Make
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public DateTime DateAdded { get; set; }
        public string UpdatedBy { get; set; }
        public string NewMake { get; set; }

    }
}