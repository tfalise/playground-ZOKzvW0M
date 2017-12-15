using System;
using System.Collections.Generic;
using System.Text;
using ExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Tests
{
    [TestClass]
    public class ValueTypeTests
    {
        private bool _shouldShowHint;
        [TestMethod]
        public void VerifyArgumentByReference()
        {
            _shouldShowHint = true;
            Check.That(ValueTypes.ExecuteIncremnt(1)).IsEqualTo(2);
            _shouldShowHint = false;
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (_shouldShowHint)
            {
                // On Failure
                PrintMessage("Hint 💡", "Maybe you should try to pass the argument by reference ? 🤔");
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
