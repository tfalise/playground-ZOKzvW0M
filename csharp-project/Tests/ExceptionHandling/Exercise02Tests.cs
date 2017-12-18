using System;
using System.IO;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace ExceptionHandling
{
    [TestClass]
    public class Exercise02Tests
    {
        private bool _shouldShowHint;
        [TestMethod]
        public void VerifyItCatchesTheRightExceptionType()
        {
            _shouldShowHint = true;

            var users = new[]
            {
                "John Doe",
                "Anne Onymous",
                "Alain Konu"
            };

            const string path = @"C:\Exports\Users.xls";

            var argumentNullFileSystem = A.Fake<IFileSystem>();
            A.CallTo(() => argumentNullFileSystem.CreateXlsFile(A<string>._))
                .Throws<ArgumentNullException>();
            var reportWithArgumentNullException = new UserXlsReport(argumentNullFileSystem);
            Check.ThatCode(() =>
                    reportWithArgumentNullException.ExportUsersToXls(users, path))
                .DoesNotThrow();

            var invalidOperationFileSystem = A.Fake<IFileSystem>();
            A.CallTo(() => invalidOperationFileSystem.CreateXlsFile(A<string>._))
                .Throws<InvalidOperationException>();
            var reportWithInvalidOperationException = new UserXlsReport(invalidOperationFileSystem);
            Check.ThatCode(() =>
                    reportWithInvalidOperationException.ExportUsersToXls(users, path))
                .Throws<InvalidOperationException>();

            _shouldShowHint = false;
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (_shouldShowHint)
            {
                // On Failure
                PrintMessage("Hint 💡", "Make sure you only catch the right exception type ! 🤔");
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
