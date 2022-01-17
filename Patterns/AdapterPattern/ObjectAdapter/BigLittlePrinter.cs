namespace Patterns.AdapterPattern.ObjectAdapter
{
    public class BigLittlePrinter : IBigPrinter
    {
        private ILittlePrinter _printer;

        public BigLittlePrinter(ILittlePrinter printer)
        {
            _printer = printer;
        }

        public string GetUpperCaseWord()
        {
            return _printer.GetLowerCaseWord().ToUpper();
        }
    }
}
