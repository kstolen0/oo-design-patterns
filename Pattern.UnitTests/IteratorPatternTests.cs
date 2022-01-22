using FluentAssertions;
using Patterns.IteratorPattern;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class IteratorPatternTests
    {
        [Fact]
        public void BreakfastMenu_ContainsArrayOfMenuItems()
        {
            var sut = new BreakfastMenu();

            var menuItems = sut.Menu;

            menuItems.Should().BeOfType<MenuItem[]>();
        }

        [Fact]
        public void CanEnumerateThroughBreakfastMenu()
        {
            var sut = new BreakfastMenu();

            EnumerateThroughMenu(sut);
        }

        [Fact]
        public void LunchMenu_ContainsListOfMenuItems()
        {
            var sut = new LunchMenu();

            var menuItems = sut.Menu;

            menuItems.Should().BeOfType<List<MenuItem>>();
        }

        [Fact]
        public void CanEnumerateThroughLunchMenu()
        {
            var sut = new LunchMenu();

            EnumerateThroughMenu(sut);
        }

        private void EnumerateThroughMenu(IEnumerable<MenuItem> menu)
        {
            foreach (var item in menu)
            {
                continue;
            }
        }
    }
}
