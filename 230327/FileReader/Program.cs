namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _dataFileName = "data.txt";
            var _filePath = "";
            var _appPath = Directory.GetCurrentDirectory();
            _appPath.PrintVar("bin  AppPath");
            _appPath = new DirectoryInfo(_appPath).Parent.Parent.Parent.FullName;
            _appPath.PrintVar("root AppPath");
            _filePath = Path.Combine(_appPath, _dataFileName);
            _filePath.PrintVar("file path");

            ReadFile(_filePath);
                
            Console.ReadLine();
        }

        static void ReadFile(string path)
        {
            var text = "";
            try
            {
                text = File.ReadAllText(path);
                Console.WriteLine("Text: " + text);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                Console.WriteLine("Reading done.");
            }
        }
    }
}