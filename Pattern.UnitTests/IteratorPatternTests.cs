using FluentAssertions;
using Patterns.IteratorPattern;
using System.Collections.Generic;
using System.Linq;
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

            sut.Count().Should().BeGreaterThan(0);
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

            sut.Count().Should().BeGreaterThan(0);
        }

        [Fact]
        public void CanConcatenateAndEnumerateThroughBothMenus()
        {
            var breakfastMenu = new BreakfastMenu();
            var lunchMenu = new LunchMenu();

            var bothMenus = breakfastMenu.Concat(lunchMenu);

            EnumerateThroughMenu(bothMenus);

            bothMenus.Count().Should().Be(breakfastMenu.Count() + lunchMenu.Count());
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
