using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.IteratorPattern
{
    public class BreakfastMenuEnum : IEnumerator<MenuItem>
    {
        public MenuItem[] _menu;

        // initialize enumerator position prior to first element
        private int _position = -1;

        public BreakfastMenuEnum(MenuItem[] menu)
        {
            _menu = menu;
        }

        object IEnumerator.Current { get { return Current; } }

        public MenuItem Current
        {
            get
            {
                try
                {
                    return _menu[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _menu.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {

        }
    }
}
