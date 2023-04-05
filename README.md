using System.ComponentModel;

namespace HW_23._04._03_FR;
class Program
{
    static void Main(string[] args)
    {
        string _directory = "";
        string _fileName = "Test File.txt";
        string _fullPath = "";
        string _command;
        string _text = "";
        List<string> _data = new List<string>();
        bool _needExit = false;

        _data = ReadFile();

        while (!_needExit)
        {
            ReadCommand();

            ExecuteCommand();
        }

        Console.ReadKey();
        //END PROGRAMM





        List<string> ReadFile()
        {
            _directory = Directory.GetCurrentDirectory();
            _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName;
            _fullPath = Path.Combine(_directory, _fileName);
            return File.ReadAllLines(_fullPath).ToList();
        }

        void ReadCommand()
        {
            Console.Write("\n\n\nВыберите команду: \"read\" или \"write\" или \"exit\": ");
            _command = Console.ReadLine().Trim().ToLower();

        }

        void ExecuteCommand()
        {
            switch (_command)
            {
                case "read":
                    PrintData();
                    break;
                case "write":
                    WriteData();
                    AppendData(_text);
                    WriteDataToFile();
                    break;
                case "exit":
                    _needExit = true;
                    break;
                default:
                    Console.WriteLine("Введена некорректная команда");
                    break;
            }
        }
        void PrintData()
        {
            Console.Clear();
            Console.Write(string.Join("\n\n",_data));
        }

        string WriteData()
        {
            Console.WriteLine("\nВведите текст: \n");
            _text = Console.ReadLine();
            return _text;
        }

        void AppendData(string data)
        {
            _data.Clear();
            _data.Add(DateTime.Today.ToString());
            _data.Add(_fileName);
            _data.Add(data);
        }

        void WriteDataToFile()
        {
            File.WriteAllLines(_fullPath, _data);    
        }
    }
}
