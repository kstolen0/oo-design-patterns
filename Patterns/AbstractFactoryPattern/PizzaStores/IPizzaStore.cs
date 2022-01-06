using Patterns.AbstractFactoryPattern.Pizzas;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public interface IPizzaStore
    {
        IPizza OrderPizza(string type);
    }
}
