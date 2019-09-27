namespace PaperSchoolTrainers.Migrations
{
    using PaperSchoolTrainers.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PaperSchoolTrainers.Models.TrainersDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PaperSchoolTrainers.Models.TrainersDb context)
        {
            var trainers = new List<Trainer>
            {
                new Trainer{ FirstName="Yiorgos", LastName="Chorman", Subject="C#", Salary = 18888},
                new Trainer{ FirstName="Mpampis", LastName="Sougias", Subject="C#", Salary = 12000},
                new Trainer{ FirstName="Nikolas", LastName="Maxairas", Subject="C#", Salary = 11000},
                new Trainer{ FirstName="Afroditi", LastName="Xepapa", Subject="C#", Salary = 15000},
                new Trainer{ FirstName="Maria", LastName="Maraki", Subject="C#", Salary = 14000},
                new Trainer{ FirstName="Johnys", LastName="Rebelos", Subject="C#", Salary = 11111},
                new Trainer{ FirstName="Markos", LastName="Markou", Subject="C#", Salary = 10000},
                new Trainer{ FirstName="Jessica", LastName="Rabbit", Subject="C#", Salary = 8000},
                new Trainer{ FirstName="Manolios", LastName="Syntexnos", Subject="Java", Salary = 1000},
                new Trainer{ FirstName="Maria", LastName="Karga", Subject="Java", Salary = 2000},
                new Trainer{ FirstName="Stelios", LastName="Metalos", Subject="Java", Salary = 3000},
                new Trainer{ FirstName="Zaxarias", LastName="Fasarias", Subject="Java", Salary = 4000}
            };
            trainers.ForEach(t => context.Trainers.AddOrUpdate(t));
            context.SaveChanges();
        }
    }
}
