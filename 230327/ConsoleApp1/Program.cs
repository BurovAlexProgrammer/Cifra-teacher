string s = "Test variable";
int i = 123;

Extension.PrintVar("Значение s", s);
Extension.PrintVar("Значение i", i);

try
{
    int sum = Extension.Sum(5, 10);

}
catch (Exception exc)
{
    Console.WriteLine("Ошибка: " + exc.Message);
}


Console.ReadLine();