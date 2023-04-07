
namespace ConsoleApp7
{
    public class Number
    {
        public int Value = 1;
        public string Text = "None";

        public void ReadValue()
        {
            Console.WriteLine("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            Value = input;
        }

        public void ReadText()
        {
            Console.WriteLine("Введите текст: ");
            Text = Console.ReadLine();
        }
    }
}
