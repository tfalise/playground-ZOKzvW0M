using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    static class Methods
    {
        public static void ThatThrowsAGenericException()
        {
            throw new Exception("Catch me if you can!");
        }
    }
}
