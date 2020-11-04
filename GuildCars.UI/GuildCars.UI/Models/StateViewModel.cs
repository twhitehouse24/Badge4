using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Models
{
    public class StateViewModel
    {
        public string State_Abbrev { get; set; }
        public IEnumerable<SelectListItem> StateList { get; set; }
        public ListItem Listitem { get; internal set; }
        public PurchaseVehicleViewModel purchaseVehicleViewModel { get; set; }
    }
}