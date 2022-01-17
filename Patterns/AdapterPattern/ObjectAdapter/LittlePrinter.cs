namespace Patterns.AdapterPattern.ObjectAdapter
{
    public class LittlePrinter : ILittlePrinter
    {
        private string _word;

        public LittlePrinter(string word)
        {
            _word = word;
        }

        public string GetLowerCaseWord()
        {
            return _word.ToLower();
        }
    }
}
