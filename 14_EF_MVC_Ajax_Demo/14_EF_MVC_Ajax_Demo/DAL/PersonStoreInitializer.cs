using Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.DAL
{
    public class PersonStoreInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        public static void SeedUser(PersonContext context)
        {
            var persons = new List<Person>
            {
                new Person() { FirstName = "Jan", LastName = "Kowalski" },
                new Person() { FirstName = "Krzysztof", LastName = "Nowak" },
                new Person() { FirstName = "Mariusz", LastName = "Brzęczyszczykiewicz" },
                new Person() { FirstName = "Janusz", LastName = "Marecki" },
                new Person() { FirstName = "Katarzyna", LastName = "Złotkowska" },
                new Person() { FirstName = "Julian", LastName = "Lubosiński" },
                new Person() { FirstName = "Grzegorz", LastName = "Rogowski" },
                new Person() { FirstName = "Bartłomiej", LastName = "Zasiński" },
                new Person() { FirstName = "Jan", LastName = "Deweloperski" },
                new Person() { FirstName = "Michał", LastName = "Kleczkowy" },
                new Person() { FirstName = "Karol", LastName = "Świtała" },
            };

            persons.ForEach(p => context.Persons.Add(p));
            context.SaveChanges();
        }

    }
}