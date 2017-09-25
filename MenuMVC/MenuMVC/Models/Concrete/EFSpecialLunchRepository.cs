using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuMVC.Models.Entities;
using MenuMVC.Models.Abstract;

namespace MenuMVC.Models.Concrete
{
    public class EFSpecialLunchRepository : ISpecialLunchRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<SpecialLunch> SpecialLunches
        {
            get { return context.SpecialLunches; }
        }
    }
}