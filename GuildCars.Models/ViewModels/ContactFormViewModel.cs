using GuildCars.Models.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GuildCars.Models.ViewModels
{
    public class ContactFormViewModel : IValidatableObject
    {
        [Required(ErrorMessage = ("The name field cannot be blank"))]
        public string Name { get; set; }

        [Required(ErrorMessage = ("Please enter a message"))]
        public string Message { get; set; }


        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Phone(ErrorMessage = ("Phone number format not valid"))]
        public string Phone { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Email) && string.IsNullOrWhiteSpace(Phone))
                yield return new ValidationResult("Must provide value for either Email or Phone.", new string[] { "Email", "Phone" });
        }



        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();
        //    if (Phone is null && Email is null)
        //    {
        //        errors.Add(new ValidationResult("Either Phone or Email must entered!"));
        //    }

        //    return errors;
        //}
    }
}