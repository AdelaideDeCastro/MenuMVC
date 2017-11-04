using System.Collections.Generic;
using MenuMVC.Models.Entities;

namespace MenuMVC.Models.Abstract
{
    interface IVegetableRepository
    {
        IEnumerable<Vegetable> Vegetables { get; }
    }
}
