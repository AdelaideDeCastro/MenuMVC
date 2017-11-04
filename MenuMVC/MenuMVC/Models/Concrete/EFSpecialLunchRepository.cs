using System.Collections.Generic;
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