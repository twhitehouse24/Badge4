using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Attributes
{
    public class ValidateSalesPrice : ValidationAttribute
    {

       public bool IsValid(decimal FirstSalePrice, decimal PurchasePrice)
        {

            FirstSalePrice = FirstSalePrice *.95M;

            if (PurchasePrice > FirstSalePrice)
            {

                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}