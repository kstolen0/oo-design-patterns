using System.Collections;
using System.Collections.Generic;

namespace Patterns.IteratorPattern
{
    public class BreakfastMenu : IEnumerable<MenuItem>
    {
        public MenuItem[] Menu { get; init; }

        public BreakfastMenu()
        {
            Menu = new MenuItem[2];
            Menu[0] = new MenuItem
            {
                Name = "item1",
                Description = "desc1",
            };

            Menu[1] = new MenuItem
            {
                Name = "item2",
                Description = "desc2",
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public BreakfastMenuEnum GetEnumerator()
        {
            return new BreakfastMenuEnum(Menu);
        }

        IEnumerator<MenuItem> IEnumerable<MenuItem>.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
