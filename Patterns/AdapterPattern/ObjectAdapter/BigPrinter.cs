namespace Patterns.AdapterPattern.ObjectAdapter
{
    public class BigPrinter : IBigPrinter
    {
        private string _word;

        public BigPrinter(string word)
        {
            _word = word;
        }

        public string GetUpperCaseWord()
        {
            return _word.ToUpper();
        }
    }
}
