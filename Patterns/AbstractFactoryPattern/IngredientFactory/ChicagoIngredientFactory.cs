using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using Patterns.AbstractFactoryPattern.IngredientFactory.Sauce;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public class ChicagoIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ChicagoStyleCheese();
        }

        public IPepperoni CreatePepperoni()
        {
            return new ChicagoStylePepperoni();
        }

        public ISauce CreateSauce()
        {
            return new ChicagoStyleSauce();
        }
    }
}
