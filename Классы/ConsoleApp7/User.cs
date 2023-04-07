
namespace ConsoleApp7
{
    public class User
    {
        string[] names = new string[] {"Иван", "Андрей", "Сергей", "Василий", "Тема"};
        string[] surnames = new string[] {"Иванов", "Петров", "Сидоров", "Алексеев", "Семенов"};

        public string Name;
        public string Surname;
        public int Age;


        public int GetAge()
        {
            return Age;
        }

        public void Trim()
        {
            Name = Name.Trim();
            Surname = Surname.Trim();
        }

        public void Create()
        {
            var random = new Random();
            Name = names[random.Next(5)];
            Surname = surnames[random.Next(5)];
            Age = random.Next(30) + 18;
        }

        public bool Validate()
        {
            bool isValid = true;
            if (Name == "" || Name == null)
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(Surname))
            {
                isValid = false;
            }
            if (Age < 18)
            {
                isValid = false;
            }
            return isValid;

            //Как вариант
            return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && Age >= 18;
        }

        public void PrintAgeDifference(User[] otherUsers)
        {
            for (int i = 0; i < otherUsers.Length; i++)
            {
                Console.WriteLine(Age - otherUsers[i].Age);
            }
        }
    }
}
