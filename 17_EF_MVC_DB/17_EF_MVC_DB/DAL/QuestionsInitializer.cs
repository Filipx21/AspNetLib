using _17_EF_MVC_DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _17_EF_MVC_DB.DAL
{
    public class QuestionsInitializer : DropCreateDatabaseAlways<QuestionContext>
    {
        protected override void Seed(QuestionContext context)
        {
            var customers = new List<Customer>
            {
                new Customer() { Email = "jan@kowalski.com", PhoneNumber = "595-121-232", WebsiteUrl = "www.kowalski.net" },
                new Customer() { Email = "krzysztof@nowak.com", PhoneNumber = "593-123-431", WebsiteUrl = "www.nowak.com" }
            };

            customers.ForEach(g => context.Customers.Add(g));
            context.SaveChanges();

            var questions = new List<Question>()
            {
                new Question() { CustomerId = 1, QuestionText = "Dlaczego nie działa aplikacja?", PhonePreferred = false },
                new Question() { CustomerId = 1, QuestionText = "Ile gwiazd jest na niebie?", PhonePreferred = true },
                new Question() { CustomerId = 2, QuestionText = "Kiedy przyjdzie lato?", PhonePreferred = false }
            };

            questions.ForEach(c => context.Questions.Add(c));
            context.SaveChanges();
        }
    }
}