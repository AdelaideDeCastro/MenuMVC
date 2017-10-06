using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuMVC.Models.Concrete;
using MenuMVC.Models.Abstract;
using MenuMVC.Models.Entities;
using MenuMVC.Models.Entities.ViewModel;

namespace MenuMVC.Models.ViewModels
{
    public class IndexRepository
    {
        private EFDbContext context = new EFDbContext();

        public Index index
        {
            get
            {
                var index = new Index(context.SpecialDinners, context.SpecialLunches, context.WeekDishes);
                return index;
            }
        }
    }
}