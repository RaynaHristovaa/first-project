namespace first_project
{
    internal class Program
    {
        private const string FilePath = "people.txt";
        static void Main(string[] args)
        {


            List<person> people = LoadPeopleFromFile();
            bool running = true;

            while (running)
            {
                Console.WriteLine("----Избери операция----");
                Console.WriteLine("1. Create (Добавяне на човек)");
                Console.WriteLine("2. READ (Показване на всички)");
                Console.WriteLine("3.UPDATE (Промяна на заплата)");
                Console.WriteLine("3.UPDATE (Промяна на заплата)");
                Console.WriteLine("4.DELETE (Изтриване по име)");
                Console.WriteLine("5.Изход ");
                Console.WriteLine("Избор: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Въведи име:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Въведете възраст");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Въведете заплатата");
                        double salary = double.Parse(Console.ReadLine());

                        person newPesron = new person(name, age, salary);
                        people.Add(newPesron);


                        SavePeopleToFile(people);
                        Console.WriteLine("Успешно добавен нов запис!");
                        Console.WriteLine();
                        break;
                }

            }
        }

        static List<person> LoadPeopleFromFile()
        {

            List<person> people = new List<person>();

            if (!File.Exists(FilePath))
            {
                return people;
            }
            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                person person = new person(
                    parts[0], int.Parse(parts[1]), double.Parse(parts[2]));
                people.Add(person);
            }
            return people;
        }

        static void SavePeopleToFile(List<person> people)
        {
            List<string> rows = new List<string>();
            foreach (person p in people)
            {
                rows.Add(p.ToFileRow());
            }
            File.WriteAllLines(FilePath, rows);
        }
    }
}