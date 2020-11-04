using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web;

namespace GuildCars.UI.Models
{
    public class CarViewModel : ValidationAttribute
    {

        public IEnumerable<SelectListItem> Makes { get; set; }
        public IEnumerable<SelectListItem> Models { get; set; }
        public IEnumerable<SelectListItem> BodyStyles { get; set; }
        public IEnumerable<SelectListItem> Transmissions { get; set; }
        public IEnumerable<SelectListItem> InteriorColors { get; set; }
        public IEnumerable<SelectListItem> ExteriorColors { get; set; }
        public IEnumerable<SelectListItem> Years { get; set; }



        public int Year_Value { get; set; }
        //public Cars cars { get; set; }
        public int CarId { get; set; }
        public int ModelId { get; set; }
        public int MakeId { get; set; }


        [Required]
        public string CarYr { get; set; }

        [Required]
        [RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Invalid Vehicle Identification Number Format.")]
        public string VIN { get; set; }

        [Required]
        public string CarDescription { get; set; }
        [Required]
        public int CarType { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public decimal MSRP { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public decimal SalePrice { get; set; }



        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public int CarTrans { get; set; }
        public int CarMileage { get; set; }
        public string CarBodyStyle { get; set; }
        public string CarImageName { get; set; }

        public string CarPhoto { get; set; }
        public string PhotoPath { get; set; }
        public bool CarSold { get; set; }
        //public string FileName { get; set; }
        public bool IsFeatured { get; set; }

        public HttpPostedFileBase postedFile { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (CarType == 2 && CarMileage >= 0 && CarMileage <= 1000)
            {
                errors.Add(new ValidationResult("Mileage is incorrect for a Used Vehicle. Mileage should greater than 1000 miles."));
            }
            if (CarType == 1 && CarMileage > 1000)
            {
                errors.Add(new ValidationResult("Mileage is incorrect for a New Vehicle. Mileage should less than 1000 miles."));
            }
            if (SalePrice > MSRP)
            {
                errors.Add(new ValidationResult("Sale Price can be higher than the MSRP value."));
            }

            return errors;
        }
    }
}
   