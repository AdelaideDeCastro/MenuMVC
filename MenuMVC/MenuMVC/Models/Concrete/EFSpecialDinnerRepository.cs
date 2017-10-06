using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuMVC.Models.Entities;
using MenuMVC.Models.Abstract;

namespace MenuMVC.Models.Concrete
{
    public class EFSpecialDinnerRepository : ISpecialDinnerRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<SpecialDinner> SpecialDinners
        {
            get { return context.SpecialDinners; }
        }
    }
}