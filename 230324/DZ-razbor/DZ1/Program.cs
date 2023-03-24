

namespace SN_HW_23._03._23;
class Program
{
    enum Types
    {
        StringType,
        NumberType
    }

    static void Main(string[] args)
    {
        string _userValue;
        float _value;
        string valueType = "";
        const string NumberType = "number";
        const string StringType = "string";

        while (true)
        {
            _userValue = ReadValue();

            if (_userValue == "exit") break;

            valueType = GetValueType();

            switch (valueType)
            {
                case NumberType:
                    PrintNumberInfo();
                    break;
                case StringType:
                    PrintStringInfo();
                    break;
            }
        }

        Console.ReadKey();



        string ReadValue()
        {
            Console.Write("Введите значение: ");
            return Console.ReadLine().Replace(".", ",");
        }

        string GetValueType()
        {
            bool isNumber = float.TryParse(_userValue, out _value);

            return isNumber ? NumberType : StringType;
        }

        void PrintNumberInfo()
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

        void PrintStringInfo()
        {
            char[] separators = new char[] { ' ', ',', '.' };
            string[] words = _userValue.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount == 1)
            {
                Console.Write($"{_userValue} -  Слово.\t");
                Console.WriteLine($"Длина слова =  {_userValue.Length}\n");
            }
            else
            {
                Console.Write($"{_userValue} -  Предложение.\t");
                Console.WriteLine($"Количество слов =  {wordCount}\n");
            }
        }
    }
}

