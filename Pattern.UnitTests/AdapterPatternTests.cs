using FluentAssertions;
using Patterns.AdapterPattern;
using Patterns.AdapterPattern.ObjectAdapter;
using Xunit;

namespace UnitTests
{
    public class AdapterPatternTests
    {
        [Fact]
        public void BigPrinter_PrintsInUpperCase()
        {
            string word = "testing";
            IBigPrinter sut = new BigPrinter(word);

            var result = sut.GetUpperCaseWord();

            result.Should().Be(word.ToUpper());
        }

        [Fact]
        public void LittlePrinter_PrintsInLowerCase()
        {
            string word = "TESTING";
            ILittlePrinter sut = new LittlePrinter(word);

            var result = sut.GetLowerCaseWord();

            result.Should().Be(word.ToLower());
        }

        [Fact]
        public void ObjectExpectingBigPrinter_AssignsBigPrinterValueToAttribute()
        {
            string word = "testing";
            IBigPrinter bigPrinter = new BigPrinter(word);

            BigWordStore sut = new BigWordStore(bigPrinter);

            sut.Word.Should().Be(word.ToUpper());
        }

        [Fact]
        public void UseLittlePrinterInObjectExpectingBigPrinter_Using_ObjectAdapterPattern()
        {
            var word = "TeStInG";
            ILittlePrinter littlePrinter = new LittlePrinter(word);
            IBigPrinter printer = new BigLittlePrinter(littlePrinter);

            BigWordStore sut = new BigWordStore(printer);

            sut.Word.Should().Be(word.ToUpper());
        }
    }
}
