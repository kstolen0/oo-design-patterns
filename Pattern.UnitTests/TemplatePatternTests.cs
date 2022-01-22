using FluentAssertions;
using Patterns.TemplatePattern;
using Patterns.TemplatePattern.SubclassingMethod;
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

        [Fact]
        public void ChildClassA_Algorithm_Returns3()
        {
            ParentClass sut = new ChildClassA();

            sut.Algorithm().Should().Be(3);
        }

        [Fact]
        public void ChildClassB_Algorithm_Returns4()
        {
            ParentClass sut = new ChildClassB();

            sut.Algorithm().Should().Be(4);
        }
    }
}
