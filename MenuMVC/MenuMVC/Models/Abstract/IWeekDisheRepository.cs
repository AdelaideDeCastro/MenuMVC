using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuMVC.Models.Entities;

namespace MenuMVC.Models.Abstract
{
    interface IWeekDisheRepository{
        IEnumerable<WeekDishe> WeekDishes { get; }
    }
}
