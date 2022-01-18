using System;

namespace Patterns.TemplatePattern
{
    /// <summary>
    /// This class implements a step in the Array.Sort algorithm, namely, the CompareTo method
    /// </summary>
    public class CustomObject : IComparable
    {
        public int Value { get; init; }
        public CustomObject(int value)
        {
            Value = value;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            CustomObject other = obj as CustomObject;

            if (other != null)
            {
                return Value.CompareTo(other.Value);
            }
            else
            {
                throw new ArgumentException($"Object is not typeof {nameof(CustomObject)}");
            }
        }
    }
}
