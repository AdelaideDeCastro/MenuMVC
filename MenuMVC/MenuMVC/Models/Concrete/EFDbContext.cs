using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MenuMVC.Models.Entities;

namespace MenuMVC.Models.Concrete
{
    public class EFDbContext : DbContext {
        public DbSet<WeekDishe> WeekDishes { get; set; }
        public DbSet<SpecialLunch> SpecialLunches { get; set; }
        public DbSet<SpecialDinner> SpecialDinners { get; set; }
    }
}