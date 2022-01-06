using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using System;

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
            throw new NotImplementedException();
        }
    }
}
