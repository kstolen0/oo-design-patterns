using Patterns.AdapterPattern.ObjectAdapter;

namespace Patterns.AdapterPattern
{
    public class BigWordStore
    {
        public string Word { get; init; }

        public BigWordStore(IBigPrinter printer)
        {
            Word = printer.GetUpperCaseWord();
        }
    }
}
