using System.Collections.Generic;
using MenuMVC.Models.Entities;
using MenuMVC.Models.Abstract;

namespace MenuMVC.Models.Concrete
{
    public class EFWeekDisheRepository : IWeekDisheRepository {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<WeekDishe> WeekDishes
        {
            get { return context.WeekDishes; }
        }
    }
}