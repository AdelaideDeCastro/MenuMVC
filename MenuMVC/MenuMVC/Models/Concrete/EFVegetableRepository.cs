using System.Collections.Generic;
using MenuMVC.Models.Entities;
using MenuMVC.Models.Abstract;

namespace MenuMVC.Models.Concrete.ViewModels
{
    public class EFDbVegetableRepository : IVegetableRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Vegetable> Vegetables
        {
            get { return context.Vegetables; }
        }
    }
}