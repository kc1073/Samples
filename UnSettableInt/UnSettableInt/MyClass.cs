using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnSettableInt
{
    public class MyClass
    {
        public class UnSettable 
        {
            public UnSettable(int v)
            {
                Console.WriteLine("Unsettable constructor value {0}", v);
                _value = v;
            }

            public static implicit operator UnSettable (int v)
            {
                Console.WriteLine("Unsettable implicit conversion to UnSettable {0}", v);
                return new UnSettable(v);
            }

            public static implicit operator int(UnSettable v)
            {
                Console.WriteLine("Unsettable implicit conversion to int {0}", v);
                return v._value;
            }

            public static UnSettable operator ++ (UnSettable v)
            {
                UnSettable result = new UnSettable(v._value + 1);
                Console.WriteLine("Unsettable operator++ {0}", result._value);
                return result;
            }

            public int _value = 0;
        }

        UnSettable _count = 10;

        public UnSettable Count
        {
            get { Console.WriteLine("Count get accessor");  return _count; }
            set { Console.WriteLine("Count set accessor");  _count = value; }
        }
    }
}
