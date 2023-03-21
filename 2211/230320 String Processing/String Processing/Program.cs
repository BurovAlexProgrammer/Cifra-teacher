using System.Text;

char[] _separators = new char[] { ' ', ',', '.' };
string _result = "";
string _result2 = "";

StringBuilder _stringBuilder = new StringBuilder();
_stringBuilder.Append(ReadLine());

StringBuilder _stringBuilder2 = new StringBuilder();
_stringBuilder2.Append(ReadLine());

PrintCommands();
string _command = ReadCommand();

_result = ExecuteCommand(_command, _stringBuilder);
_result2 = ExecuteCommand(_command, _stringBuilder2);

PrintResult(_result);
PrintResult(_result2);

Console.ReadLine();


string ExecuteCommand(string command, StringBuilder stringBuilder)
{
    string result = "";

    switch (command)
    {
        case "1":
        result = LetterCount(stringBuilder).ToString();
        break;
        case "2":
        result = WordCount(stringBuilder).ToString();
        break;
        case "3":
        result = LineWithCommaSeparator(stringBuilder);
        break;
        case "4":
        result = UpperCase(stringBuilder);
        break;
    }

    return result;
}

string UpperCase(StringBuilder stringBuilder)
{
    for (int i = 0; i < stringBuilder.Length; i++)
    {
        stringBuilder[i] = char.ToUpper(stringBuilder[i]);
    }

    return stringBuilder.ToString();
}

string LineWithCommaSeparator(StringBuilder stringBuilder)
{
    string[] words = stringBuilder.ToString().Split(_separators, StringSplitOptions.RemoveEmptyEntries);
    return string.Join(",", words);
}

void PrintResult(string resultMessage)
{
    Console.WriteLine("Результат:" + resultMessage);
}

string ReadLine()
{
    Console.Write("Введите строку: ");
    return Console.ReadLine();
}

void PrintCommands()
{
    Console.WriteLine("Выберите команду:");
    Console.WriteLine("1 - Количество букв");
    Console.WriteLine("2 - Количество слов");
    Console.WriteLine("3 - Вывести слова через запятую");
    Console.WriteLine("4 - Всё с большой буквы");
}

string ReadCommand()
{
    return Console.ReadLine();
}

int LetterCount(StringBuilder stringBuilder)
{
    stringBuilder = stringBuilder.Replace(" ", "");
    return stringBuilder.Length;
}

int WordCount(StringBuilder stringBuilder)
{
    string[] words = stringBuilder.ToString().Split(_separators, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}