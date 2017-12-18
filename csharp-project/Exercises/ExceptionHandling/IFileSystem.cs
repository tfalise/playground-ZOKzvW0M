namespace ExceptionHandling
{
    public interface IFileSystem
    {
        void CreateXlsFile(string filePath);
        void WriteAllLines(string userData, string filePath);
    }
}