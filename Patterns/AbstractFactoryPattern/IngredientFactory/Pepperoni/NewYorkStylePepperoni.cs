namespace Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni
{
    public class NewYorkStylePepperoni : IPepperoni
    {
        public string Description { get; }

        public NewYorkStylePepperoni()
        {
            Description = "NY style pepperoni";
        }
    }
}
