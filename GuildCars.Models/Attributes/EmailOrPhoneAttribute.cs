using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GuildCars.Models.Attributes
{
    public class EmailOrPhoneAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value as string;
            var phone = value as string;


            if (IsValidEmailAddress(email) is false && IsValidPhoneNumber(phone) is false)
            {
                return new ValidationResult("Either Phone, Email or Both needs to be entered!");
                
            }
            else
            {
                return ValidationResult.Success;
                
            }



            bool IsValidEmailAddress(string emailToValidate)
            {
                bool result = false;
                if (emailToValidate is null)
                {
                    return false;
                }
                else
                {
                    var emailAttribute = new EmailAddressAttribute();
                    result = emailAttribute.IsValid(emailToValidate);
                    return emailAttribute.IsValid(emailToValidate);
                }
            }

            bool IsValidPhoneNumber(string phoneNumberToValidate)
            {
                bool result = false;
                if (phoneNumberToValidate is null)
                {
                    return false;
                }
                else
                {
                    var regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
                    result = regex.IsMatch(phoneNumberToValidate);
                    return regex.IsMatch(phoneNumberToValidate);
                }

            }
        }
    }
}