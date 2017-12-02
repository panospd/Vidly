using System;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId==MembershipType.Unknown
                ||customer.MembershipTypeId == MembershipType.PatAsYouGo)
                return ValidationResult.Success;
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;

            return (age >=18) 
                ? ValidationResult.Success 
                : new ValidationResult("You hould be at least 18 years old to go on a membership type.");
        }
    }
}