
public static class Extension
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }


    public static void PrintVar(string title, string variable)
    {
        Console.WriteLine("-------STRING----------");
        Console.WriteLine($"{title}: " + variable);
        Console.WriteLine("-------------------------------------");
    }

    public static void PrintVar(string title, int variable)
    {
        Console.WriteLine("-----INTEGER-----------");
        Console.WriteLine($"{title}: " + variable);
        Console.WriteLine("-------------------------------------");
    }
}
