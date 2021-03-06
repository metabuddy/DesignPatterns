﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; }
        public decimal Cost { get; }
        public Enum Size { get; set; }

        public DarkRoast(Enum size)
        {
            Description = Size + " Dark Roast";
            Cost = 1.60m;
            Size = size;
        }

    }
}
