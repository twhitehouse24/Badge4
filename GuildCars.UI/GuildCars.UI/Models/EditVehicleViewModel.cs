using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Models
{
    public class EditVehicleViewModel
    {
        public IEnumerable<SelectListItem> Makes { get; set; }
        public IEnumerable<SelectListItem> Models { get; set; }
        public IEnumerable<SelectListItem> BodyStyles { get; set; }
        public IEnumerable<SelectListItem> Transmissions { get; set; }
        public IEnumerable<SelectListItem> InteriorColors { get; set; }
        public IEnumerable<SelectListItem> ExteriorColors { get; set; }
        public IEnumerable<SelectListItem> Years {get;set;}

        public Cars cars { get; set; }


        public int Carid { get; set; }
        public int ModelId { get; set; }
        public int MakeId { get; set; }
        public int CarYr { get; set; }
        public int CarType { get; set; }
        public string CarBodyStyle { get; set; }
        public decimal MSRP { get; set; }
        public decimal SalePrice { get; set; }
        public string Vin { get; set; }
        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public int CarTrans { get; set; }
        public int CarMileage { get; set; }
        public string CarDescription { get; set; }
        public string CarImageName { get; set; }
        public string CarPhoto { get; set; }
        public bool CarSold { get; set; }
        public string FileName { get; set; }

        public HttpPostedFileBase postedFile { get; set; }

    }
}