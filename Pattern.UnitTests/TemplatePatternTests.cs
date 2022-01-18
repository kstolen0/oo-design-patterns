using FluentAssertions;
using Patterns.TemplatePattern;
using System;
using Xunit;

namespace UnitTests
{
    public class TemplatePatternTests
    {
        [Fact]
        public void SortAnArrayOfMyCustomObject()
        {
            CustomObject[] sut = {
                new CustomObject(5),
                new CustomObject(4),
                new CustomObject(3),
            };

            Array.Sort(sut);

            sut[0].Value.Should().Be(3);
        }
    }
}
