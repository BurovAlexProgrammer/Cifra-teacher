namespace FileReader;
class Program
{
    static void Main(string[] args)
    {
        string _directory = "";
        string _fileName = "Data.txt";
        string _fullPath = "";
        string _line;
        List<string> _data = new List<string>();
        bool _needExit = false;

        _data = ReadFile();

        while (!_needExit)
        {
            Console.Clear();

            PrintData();

            ReadCommand();

            ExecuteCommand();
        }

        WriteDataToFile();

        Console.ReadLine();







        void AppendData(string data)
        {
            _data.Add(data);
        }

        List<string> ReadFile()
        {
            _directory = Directory.GetCurrentDirectory(); // Путь до ехе-файла
            _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName; // Перейти по каталогу на три уровня вверх
            _fullPath = Path.Combine(_directory, _fileName); // Комбинировать путь + папка или + файл
            return File.ReadAllLines(_fullPath).ToList(); // Чтение файла и запись в string переменную
        }

        void WriteDataToFile()
        {
            File.WriteAllLines(_fullPath, _data); // Запись string-данных в файл по пути _fullPath
            Console.WriteLine("\nФайл сохранен");
        }

        void PrintData()
        {
            int i = 0;

            Console.WriteLine("DATA: \n");
            foreach (var note in _data)
            {
                i++;
                Console.WriteLine($"{i})\t{note}");
            }
            Console.WriteLine("______________________");
        }

        void ReadCommand()
        {
            Console.WriteLine("\n Для помощи нажмите \"help\" или \"?\"");
            Console.Write("\n Введите данные или выберите команду: ");
            _line = Console.ReadLine().Trim().ToLower();

        }

        void WriteHelp()
        {
            Console.WriteLine("\n\texit - выход из программы\n");
            Console.WriteLine("\tremove - удаление строки (требуется ввод номера строки)\n");
            Console.WriteLine("\tcount lines - подсчитать количество строк\n");
            Console.WriteLine("\tcount int lines - подсчитать количество числовых строк\n");
            Console.WriteLine("\tcount int lines sum - подсчитать сумму, выбранную со всех числовых строк\n");
            Console.ReadKey();
        }

        void RemoveLine()
        {
            Console.Write("\nКакую строку удаляем? : ");
            int lineNumber = int.Parse(Console.ReadLine());

            try
            {
                _data.RemoveAt(lineNumber - 1);
            }
            catch
            {
                Console.WriteLine("Ошибка! Не удалось удалить строку");
                Console.ReadKey();
            }
        }

        void ExecuteCommand()
        {
            switch (_line)
            {
                case "help":
                case "?":
                    WriteHelp();
                    break;
                case "exit":
                    _needExit = true;
                    break;
                case "remove":
                    RemoveLine();
                    break;
                case "count lines":
                    CountLines();
                    break;
                case "count int lines":
                    CountIntLines();
                    break;
                case "count int lines sum":
                    CountIntLinesSum();
                    break;
                default:
                    AppendData(_line);
                    break;
            }
        }

        void CountLines()
        {
            int lineCounter = 0;

            foreach (var note in _data)
            {
                lineCounter++;
            }

            Console.WriteLine($"\nКоличество строк = {lineCounter}");  //Можно просто _data.Count
            Console.ReadKey();
        }

        void CountIntLines()
        {
            float intLine = 0;
            float intLineCounter = 0;

            foreach (var _line in _data)
            {
                try
                {
                    intLine = float.Parse(_line); //Тоже вариант но лучше использовать float.TryParse
                    intLineCounter++;
                }
                catch
                {
                    continue;
                }
            }

            Console.WriteLine($"\nКоличество числовых строк = {intLineCounter}");
            Console.ReadKey();
        }

        void CountIntLinesSum()
        {
            float intLine = 0;
            float intLineSum = 0;

            foreach (var _line in _data)
            {
                try
                {
                    intLine = float.Parse(_line.Replace(",", "."));// в случае ошибки - поменять местами "," и "." - зависит от настроек вашей системы
                    intLineSum += intLine; //тоже лучше tryParse 
                }
                catch
                {
                    continue;
                }
            }

            Console.WriteLine($"\nСумма, выбранная со всех числовых строк = {intLineSum}");
            Console.ReadKey();
        }
    }
}


