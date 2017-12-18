// { autofold
using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class UserXlsReport
    {
        private readonly IFileSystem _fileSystem;

        public UserXlsReport(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        // }
        public void ExportUsersToXls(IEnumerable<string> users, string filePath)
        {
            // fix me : catch the exception
            _fileSystem.CreateXlsFile(filePath);

            var userData = string.Join(@"\n", users);
            _fileSystem.WriteAllLines(userData, filePath);
        }
        // { autofold
    }
}
// }