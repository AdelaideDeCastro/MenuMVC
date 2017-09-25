using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuMVC.Models.Entities.ViewModel
{
    public class Index
    {
        public Index(IEnumerable<SpecialLunch> specialLunches, IEnumerable<WeekDishe> weekDishes)
        {
            this.specialLunches = specialLunches;
            this.weekDishes = weekDishes;
        }
        public IEnumerable<SpecialLunch> specialLunches { get; set; }
        public IEnumerable<WeekDishe> weekDishes{ get; set; }
    }
}