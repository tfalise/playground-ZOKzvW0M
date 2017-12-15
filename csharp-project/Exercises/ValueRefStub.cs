using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ValueRefStub
    {
        private static ArrayList PassByValue(ArrayList arrayList)
        {
            // Now Change the first position value
            arrayList[1] = 90;
            arrayList = new ArrayList() { 101, 102, 103, 104 };
            Console.WriteLine(arrayList[1]);
        }
    }
}
