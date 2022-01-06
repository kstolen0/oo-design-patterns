﻿using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public class CheesePizza : IPizza
    {
        public ICheese Cheese { get; }

        public IPepperoni Pepperoni { get; }

        public CheesePizza(IIngredientFactory ingredients)
        {
            Cheese = ingredients.CreateCheese();
        }
    }
}
