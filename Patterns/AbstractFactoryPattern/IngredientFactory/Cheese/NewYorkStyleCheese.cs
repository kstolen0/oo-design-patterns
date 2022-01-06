namespace Patterns.AbstractFactoryPattern.IngredientFactory.Cheese
{
    public class NewYorkStyleCheese : ICheese
    {
        public string Description { get; }

        public NewYorkStyleCheese()
        {
            Description = "NY style cheese";
        }

    }
}
