using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.UI.Models
{
    public class InventoryViewModel
    {
        public List<Cars> UsedList { get; set; }
        public List<Cars> NewList { get; set; }
    }
}