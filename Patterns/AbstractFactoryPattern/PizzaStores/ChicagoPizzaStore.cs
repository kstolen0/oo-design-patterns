using Patterns.AbstractFactoryPattern.IngredientFactory;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        {
            _ingredientFactory = new ChicagoIngredientFactory();
        }
    }
}
