using FluentAssertions;
using Patterns.CommandPattern;
using Patterns.CommandPattern.Commands;
using Xunit;

namespace UnitTests
{
    public class CommandPatternTests
    {
        [Fact]
        public void RemoteContainsOnlyNoCommandObjectsByDefaults()
        {
            var remote = new Remote();

            foreach (ICommand c in remote.Commands)
            {
                c.GetType().Should().Be<NoCommand>();
            }
        }
    }
}
