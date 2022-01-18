using FluentAssertions;
using Patterns.TemplatePattern;
using Patterns.TemplatePattern.SubclassingMethod;
using System;
using System.Reflection;
using Xunit;

namespace UnitTests
{
    public class TemplatePatternTests
    {

        private string _namespace = "Patterns.TemplatePattern.SubclassingMethod.";

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

        [Fact]
        public void ParentClass_Defines_NonAbstractNonVirtualAlgorithm()
        {
            var parentClass = Assembly.GetAssembly(typeof(ParentClass)).GetType(_namespace + nameof(ParentClass));

            var algorithmMethod = parentClass.GetMethod(nameof(ParentClass.Algorithm));

            algorithmMethod.IsAbstract.Should().BeFalse();
            algorithmMethod.IsVirtual.Should().BeFalse();
        }

        [Fact]
        public void ParentClass_Defines_AbstractStepB()
        {
            var parentClass = Assembly.GetAssembly(typeof(ParentClass)).GetType(_namespace + nameof(ParentClass));

            var stepBMethod = parentClass.GetMethod(nameof(ParentClass.StepB));

            stepBMethod.IsAbstract.Should().BeTrue();
        }

        [Fact]
        public void ChildClassA_InheritsFrom_ParentClass()
        {
            var childClass = Assembly.GetAssembly(typeof(ChildClassA)).GetType(_namespace + nameof(ChildClassA));

            childClass.BaseType.Name.Should().Be(nameof(ParentClass));
        }

        [Fact]
        public void ChildClassB_InheritsFrom_ParentClass()
        {
            var childClass = Assembly.GetAssembly(typeof(ChildClassB)).GetType(_namespace + nameof(ChildClassB));

            childClass.BaseType.Name.Should().Be(nameof(ParentClass));
        }
    }
}
