using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using Patterns.AbstractFactoryPattern.IngredientFactory.Sauce;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public class CheesePizza : IPizza
    {
        public ICheese Cheese { get; }

        public IPepperoni Pepperoni { get; }

        public ISauce Sauce { get; }

        public CheesePizza(IIngredientFactory ingredients)
        {
            Cheese = ingredients.CreateCheese();
            Sauce = ingredients.CreateSauce();
        }
    }
}
