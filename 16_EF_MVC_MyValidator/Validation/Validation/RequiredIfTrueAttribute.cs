using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyValidation.Validation
{

    public class RequiredIfTrueAttribute : ValidationAttribute
    {
        public string BooleanPropertyName { get; set; }

        protected override ValidationResult IsValid(object value,
                  ValidationContext validationContext)
        {
            if (GetValue<bool>(validationContext.ObjectInstance, BooleanPropertyName))
            {
                return new RequiredAttribute().IsValid(value) ?
                    ValidationResult.Success :
                    new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }

        private static T GetValue<T>(object objectInstance, string propertyName)
        {
            if (objectInstance == null) throw new ArgumentNullException("objectInstance");
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentNullException("propertyName");

            var propertyInfo = objectInstance.GetType().GetProperty(propertyName);
            return (T)propertyInfo.GetValue(objectInstance);
        }

    }



}