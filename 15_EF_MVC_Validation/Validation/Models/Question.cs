using MyValidation.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyValidation.Models
{

    public class Question : IValidatableObject
    {

        [ScaffoldColumn(false)]
        public int QuestionId { get; set; }


        [Display(Name = "Pytanie:")]
        [DataType(DataType.MultilineText)]
        public string QuestionText { get; set; }

        [Display(Name = "Adres email:")]

        [Required(ErrorMessage = "Musisz wprowadzić adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Preferowany kontakt telefoniczy")]
        public bool PhonePreferred { get; set; }

        [Display(Name = "Numer telefonu:")]


        [RequiredIfTrue(BooleanPropertyName = "PhonePreferred", ErrorMessage = "Skoro preferujesz kontakt telefoniczny, musisz podać numer.")]
        [Phone]
        [RegularExpression(@"([\+]){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})\-?[-\s]?([0-9]{3})[-\s]\-?([0-9]{3})$",
            ErrorMessage = "Numer musi być zapisany w formacie 123-123-123")]
        public string PhoneNumber { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Email.Contains("spam"))
                yield return new ValidationResult("Podany e-mail nie wygląda na prawidłowy.", new string[] { "Email" });
        }



    }


}