using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuMVC.Models.Entities.ViewModel
{
    public class Index
    {
        public IEnumerable<SpecialDinner> specialDinners { get; set; }
        public IEnumerable<SpecialLunch> specialLunches { get; set; }
        public IEnumerable<WeekDishe> weekDishes { get; set; }

        public Index(IEnumerable<SpecialDinner> specialDinners, IEnumerable<SpecialLunch> specialLunches, IEnumerable<WeekDishe> weekDishes)
        {
            this.specialDinners = specialDinners;
            this.specialLunches = specialLunches;
            this.weekDishes = weekDishes;
        }
    }
}