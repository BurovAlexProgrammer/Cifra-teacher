namespace SN_HW_23._03._23;
class Program
{
    static void Main(string[] args)
    {

        //Вариант без методов

        while (true)
        {
            string _userValue;
            float _value;

            Console.Write("Введите значение: ");
            _userValue = Console.ReadLine().Replace(",", ".");

            if (_userValue == "exit")
            {
                break;
            }

            bool isNumber = float.TryParse(_userValue, out _value);

            if (isNumber)
            {
                if (_value % 1 == 0)
                {
                    Console.WriteLine($"{_value} -  Целое число\n");
                }
                else
                {
                    Console.WriteLine($"{_value} -  Вещественное число\n");
                }
            }
            else
            {
                char[] separators = new char[] { ' ', ',', '.' };
                string[] words = _userValue.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int result = words.Length;

                if (result == 1)
                {
                    Console.Write($"{_userValue} -  Слово.\t");
                    Console.WriteLine($"Длина слова =  {_userValue.Length}\n");
                }
                else
                {
                    Console.Write($"{_userValue} -  Предложение.\t");
                    Console.WriteLine($"Количество слов =  {result}\n");
                }
            }
        }

        Console.ReadKey();
    }
}

