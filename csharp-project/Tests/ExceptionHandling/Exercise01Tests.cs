using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace ExceptionHandling
{
    [TestClass]
    public class Exercise01Tests
    {
        private bool _shouldShowHint;
        [TestMethod]
        public void VerifyExceptionIsCatched()
        {
            _shouldShowHint = true;
            Check.ThatCode(Exercise01.HandleGenericException).DoesNotThrow();
            _shouldShowHint = false;
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (_shouldShowHint)
            {
                // On Failure
                PrintMessage("Hint 💡", "Did you add a try...catch block ? 🤔");
            }
            else
            {
                // On success
                PrintMessage("Congratulations", "Continue to the next lesson");
            }
        }


        /****
            TOOLS
        *****/
        // Display a custom message in a custom channel
        private static void PrintMessage(String channel, String message)
        {
            Console.WriteLine($"TECHIO> message --channel \"{channel}\" \"{message}\"");
        }
    }
}
