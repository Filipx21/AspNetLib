using _17_EF_MVC_DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _17_EF_MVC_DB.DAL
{
    public class QuestionContext : DbContext
    {
        public QuestionContext() : base("QuestionContext") { }

        static QuestionContext()
        {
            Database.SetInitializer<QuestionContext>(new QuestionInitializer());
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}