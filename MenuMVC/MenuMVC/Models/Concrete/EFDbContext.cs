using System.Data.Entity;
using MenuMVC.Models.Entities;

namespace MenuMVC.Models.Concrete
{
    public class EFDbContext : DbContext {
        public DbSet<WeekDishe> WeekDishes { get; set; }
        public DbSet<SpecialLunch> SpecialLunches { get; set; }
        public DbSet<SpecialDinner> SpecialDinners { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
    }
}