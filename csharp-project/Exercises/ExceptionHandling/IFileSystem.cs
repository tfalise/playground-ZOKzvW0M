namespace ExceptionHandling
{
    internal interface IFileSystem
    {
        void CreateXlsFile(string filePath);
        void WriteAllLines(string userData, string filePath);
    }
}