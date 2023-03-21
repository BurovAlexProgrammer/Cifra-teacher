namespace ExerciseFour
{
    class Program
    {

        static void Main(string[] args)
        {
            int value1 = 5;
            int value2;
            string operation;
            string result = "";

            Console.WriteLine("value1: " + value1);

            value1 = ReadValue("Первое значение: ");
            operation = ReadOperation();
            value2 = ReadValue("Второе значение: ");
            Calculate();
            ShowResult();



            string ReadOperation()
            {
                string[] operators = new string[] { "+", "-", "*", ":" };
                bool tryParse = true;
                string result = "";

                while (tryParse)
                {
                    Console.Write("Оператор: ");
                    result = Console.ReadLine();
                    result = result.Trim();

                    if (operators.Contains(result))
                    {
                        tryParse = false;
                    }
                }
                return result;
            }

            int ReadValue(string message)
            {
                int result = 0;
                bool tryParse = true;

                while (tryParse)
                {
                    Console.Write(message);
                    string line = Console.ReadLine();

                    if (Int32.TryParse(line, out result))
                    {
                        tryParse = false;
                    }
                }

                return result;
            }

            void ShowResult()
            {
                Console.WriteLine("Результат: " + result);
                Console.ReadKey();
            }

            void Calculate()
            {
                switch (operation)
                {
                    case "+":
                    result = (value1 + value2).ToString();
                    break;
                    case "-":
                    result = (value1 - value2).ToString();
                    break;
                    case "*":
                    result = (value1 * value2).ToString();
                    break;
                    case ":":
                    result = (value1 / value2).ToString();
                    break;
                }
            }
        }
    }
}
