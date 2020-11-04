using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Tables
{
    public class ContactForm : ValidationAttribute
    {

        [Required(ErrorMessage = ("The name field cannot be blank"))]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        //[Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Phone(ErrorMessage = ("Phone number format not valid"))]
        public string Phone { get; set; }

        [Required(ErrorMessage = ("Please enter a message"))]
        public string Message { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Phone is null && Email is null)
            {
                errors.Add(new ValidationResult("Either Phone or Email must entered!"));
            }

            return errors;
        }
    }
}