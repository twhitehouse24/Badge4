using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuildCars.Models.Tables;

namespace GuildCars.UI.Models
{
    public class ModelsViewModel
    {

        public IEnumerable<SelectListItem> Makes { get; set; }
        public List<ModelList> Models { get; set; }

        public string NewModel { get; set; }
        public string MakeName { get; set; }



    }

}