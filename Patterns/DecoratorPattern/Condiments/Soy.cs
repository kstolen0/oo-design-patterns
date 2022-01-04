﻿using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class Soy : Condiment
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override long Cost()
        {
            return _beverage.Cost() + (long)0.5;
        }
    }
}
