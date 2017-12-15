// { autofold
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class ValueTypes
    {
// }
        public static void Increment(int value)
        {
            value = value + 1;
        }

        public static int ExecuteIncremnt(int value)
        {
            Increment(value);
            return value;
        }
// { autofold
    }
}
// }