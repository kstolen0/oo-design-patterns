using Patterns.AbstractFactoryPattern.IngredientFactory;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public NewYorkPizzaStore()
        {
            _ingredientFactory = new NewYorkIngredientFactory();
        }
    }
}
