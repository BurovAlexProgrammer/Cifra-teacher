using ConsoleApp7;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        User[] users = new User[10];

        for (int i = 0; i < users.Length; i++)
        {
            users[i] = new User();
            users[i].Create();
        }

        users[2].Name = "";
        users[4].Age = 12;


        PrintUsers();
        Console.WriteLine("--------------------");
        TrimUsers();
        users[0].PrintAgeDifference(users);
        //users[0].Age = 0;
        users[0].GetAge();
        Console.ReadKey();






        void PrintUsers()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.Write(users[i].Name + " " + users[i].Surname + "  Возраст: " + users[i].GetAge());

                if (users[i].Validate() == false) {
                    Console.Write("   -- Не корректный");
                }

                Console.WriteLine();
            }
        }

        void TrimUsers()
        {
            for (int i = 0; i < users.Length; i++)
            {
                users[i].Trim();
            }
        }
    }
}