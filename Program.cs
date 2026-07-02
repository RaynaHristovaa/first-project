namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<person> people = LoadPeopleFromFile();
            bool running = true;    

            while(running)
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
              
            }










        }
    }
}
