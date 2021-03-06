﻿using System.Collections.Generic;
using MenuMVC.Models.Entities;

namespace MenuMVC.Models.Abstract
{
    interface ISpecialDinnerRepository
    {
        IEnumerable<SpecialDinner> SpecialDinners { get; }
    }
}
