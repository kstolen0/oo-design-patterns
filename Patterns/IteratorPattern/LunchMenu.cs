using System.Collections;
using System.Collections.Generic;

namespace Patterns.IteratorPattern
{
    public class LunchMenu : IEnumerable<MenuItem>
    {
        public IList<MenuItem> Menu;

        public LunchMenu()
        {
            Menu = new List<MenuItem>();
            Menu.Add(new MenuItem { Name = "test", Description = "description" });
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return Menu.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
