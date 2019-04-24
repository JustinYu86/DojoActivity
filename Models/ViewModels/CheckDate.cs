using System;
using System.Collections.Generic;
using Activity = CSharpBelt.Models.Activity;
using System.ComponentModel.DataAnnotations;

namespace CSharpBelt.Models
{
    public class CheckDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((DateTime)value <= DateTime.Today)
            {
                return new ValidationResult("The wedding may not be at a previous date!.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}