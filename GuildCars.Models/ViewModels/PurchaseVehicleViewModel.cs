using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using GuildCars.Models.Attributes;

namespace GuildCars.UI.Models
{
    public class PurchaseVehicleViewModel: IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (SalePrice < (FirstSalePrice * 0.95d))
            {
                errors.Add(new ValidationResult("Purchase price is too low"));
            }
            if (SalePrice > MsrpPrice)
            {
                errors.Add(new ValidationResult("Purchase price is above MSRP"));
            }
            if (CustEmail is null && CustPhone is null)
            {
                errors.Add(new ValidationResult("Phone and/or Email must be entered"));
            }

            return errors;
        }


            [Required(ErrorMessage = ("Please enter customer name"))]
            public string CustName { get; set; }

            [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
            public string CustPhone { get; set; }

            [EmailAddress(ErrorMessage = "Invalid email format")]
            public string CustEmail { get; set; }

            [Required(ErrorMessage = ("Please enter a street address"))]
            public string CustStreet1 { get; set; }

            [Required(ErrorMessage = ("Please enter a city"))]
            public string CustCity { get; set; }

            [Required(ErrorMessage = ("Please enter a 5 digit zip code"))]
            [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip code must be 5 digits")]
            public string CustZip { get; set; }

            [Required(ErrorMessage = ("Please enter the purchase price"))]
            public double SalePrice { get; set; }

            [Required(ErrorMessage = ("Please enter a purchase type"))]
            public string PurchaseType { get; set; }

            [Required(ErrorMessage = ("Select a State"))]
            public string State_Abbrev { get; set; }


            public string CustStreet2 { get; set; }
            public string CustState { get; set; }
            public double FirstSalePrice { get; set; }
            public double MsrpPrice { get; set; }
            public string UserName { get; set; }
            public int CarId { get; set; }

    }

}
