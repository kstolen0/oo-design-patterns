using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public class PepperoniPizza : IPizza
    {
        public ICheese Cheese { get; }

        public IPepperoni Pepperoni { get; }

        public PepperoniPizza(IIngredientFactory ingredientFactory)
        {
            Cheese = ingredientFactory.CreateCheese();
            Pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}
