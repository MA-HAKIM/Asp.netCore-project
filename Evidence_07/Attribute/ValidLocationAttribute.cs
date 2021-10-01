using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence_07.Attribute
{
    public class ValidLocationAttribute : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-location", "Invalid location: Location will be Dhaka, Chattagram or Rajshahi");
        }

        public override bool IsValid(object value)
        {
            return value.ToString() == "Dhaka" || value.ToString() == "Chattagram" || value.ToString() == "Rajshahi";
        }
    }
}
