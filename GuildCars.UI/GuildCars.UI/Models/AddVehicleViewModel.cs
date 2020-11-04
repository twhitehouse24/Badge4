using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GuildCars.UI.Models
{
    public class AddVehicleViewModel 
    {

        public IEnumerable<SelectListItem> Makes { get; set; }
        public IEnumerable<SelectListItem> Models { get; set; }
        public IEnumerable<SelectListItem> BodyStyles { get; set; }
        public IEnumerable<SelectListItem> Transmissions { get; set; }
        public IEnumerable<SelectListItem> InteriorColors { get; set; }
        public IEnumerable<SelectListItem> ExteriorColors { get; set; }
        public IEnumerable<SelectListItem> Years { get; set; }

        public int Carid { get; set; }

        [Required(ErrorMessage = ("Please enter vehicle year"))]
        public int Year_Value { get; set; }

        [Required(ErrorMessage = ("Please select a Model"))]
        public int ModelId { get; set; }

        [Required(ErrorMessage = ("Please select a Make"))]
        public int MakeId { get; set; }

        [Required(ErrorMessage = ("Please enter vehicle year"))]
        public int CarYr { get; set; }

        [Required(ErrorMessage = ("Please enter a VIN number"))]
        [RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Invalid Vehicle Identification Number Format.")]
        public string VIN { get; set; }

        [Required(ErrorMessage = ("Please enter vehicle type"))]
        public int CarType { get; set; }

        [Required(ErrorMessage = ("Please enter bodystyle"))]
        public string BodyStyle { get; set; }

        [Required(ErrorMessage = ("Please enter the MSRP"))]
        public decimal MSRP { get; set; }

        [Required(ErrorMessage = ("Please enter a Sale price"))]
        public decimal SalePrice { get; set; }

        [Required(ErrorMessage = ("Please select a exterior color"))]
        public string ExtColor { get; set; }

        [Required(ErrorMessage = ("Please select a interior color"))]
        public string IntColor { get; set; }

        [Required(ErrorMessage = ("Please select a transmission type"))]
        public int CarTrans { get; set; }

        [Required(ErrorMessage = ("Please enter the vehicle mileage"))]
        public int CarMileage { get; set; }

        [Required(ErrorMessage = ("Please enter a description"))]
        public string CarDescription { get; set; }

        [Required(ErrorMessage = ("Please select an image file"))]
        public string CarImageName { get; set; }

        public string CarPhoto { get; set; }
        public bool CarSold { get; set; }


    }
}