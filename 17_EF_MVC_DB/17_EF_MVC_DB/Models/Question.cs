using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17_EF_MVC_DB.Models
{
    public class Question
    {
        [ScaffoldColumn(false)]
        public int QuestionId { get; set; }

        [Display(Name = "Pytanie:")]
        [DataType(DataType.MultilineText)]
        public string QuestionText { get; set; }

        [Display(Name = "Preferowany kontakt telefoniczy")]
        public bool PhonePreferred { get; set; }

        public int CustomerId { get; set; }
    }
}