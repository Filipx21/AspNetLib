using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17_EF_MVC_DB.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "Adres email:")]
        [Required(ErrorMessage = "Musisz wprowadzić adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Numer telefonu:")]
        [Phone]
        [RegularExpression(@"([\+]){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})\-?[-\s]?([0-9]{3})[-\s]\-?([0-9]{3})$",
            ErrorMessage = "Numer musi być zapisany w formacie 123-123-123")]
        public string PhoneNumber { get; set; }

        public string WebsiteUrl { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}