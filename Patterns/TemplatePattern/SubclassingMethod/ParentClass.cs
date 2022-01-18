namespace Patterns.TemplatePattern.SubclassingMethod
{
    public abstract class ParentClass
    {
        public int Algorithm()
        {
            return StepA() + StepB();
        }

        private int StepA()
        {
            return 0;
        }

        public abstract int StepB();
    }
}
