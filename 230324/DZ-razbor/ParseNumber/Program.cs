using System.Text;

string _line;
StringBuilder _valueStringBuilder = new StringBuilder();
float _value = 0f;

//ввод
Console.WriteLine("Vvedite stroky: ");
_line = Console.ReadLine();

//обработка
ParseLine(true);

if (_valueStringBuilder.Length == 0)
{
    Console.WriteLine("Error. Number not found");
}
else
{
    _value = float.Parse(_valueStringBuilder.ToString());
}

//вывод
Console.WriteLine("Number = " + _value);

void ParseLine(bool exitOnFirstLetter)
{
    for (int i = 0; i < _line.Length; i++)
    {
        char letter = _line[i];

        if (char.IsDigit(letter))
        {
            _valueStringBuilder.Append(letter);
            continue;
        }
        else if (letter == '.' || letter == ',')
        {
            _valueStringBuilder.Append(',');
            continue;
        }

        if (exitOnFirstLetter) return; 
    }
}