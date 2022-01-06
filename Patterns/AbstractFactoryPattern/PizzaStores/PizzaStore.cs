using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.Pizzas;
using System;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        protected IIngredientFactory _ingredientFactory;

        public enum Menu
        {
            Cheese,
            Pepperoni,
        }

        public IPizza OrderPizza(Menu pizzaType)
        {
            return PreparePizza(pizzaType);
        }

        private IPizza PreparePizza(Menu pizzaType)
        {
            switch (pizzaType)
            {
                case Menu.Cheese:
                    return new CheesePizza(_ingredientFactory);
                case Menu.Pepperoni:
                    return new PepperoniPizza(_ingredientFactory);
                default:
                    throw new ArgumentException("invalid input", nameof(pizzaType));
            }
        }
    }
}
