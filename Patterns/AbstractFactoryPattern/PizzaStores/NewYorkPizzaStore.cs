using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.Pizzas;
using System;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public class NewYorkPizzaStore : IPizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            IIngredientFactory ingredientFactory = new NewYorkIngredientFactory();

            switch (type)
            {
                case "Cheese":
                    return new CheesePizza(ingredientFactory);
                case "Pepperoni":
                    return new PepperoniPizza(ingredientFactory);
                default:
                    throw new ArgumentException("Invalid argument", nameof(type));
            }
        }
    }
}
