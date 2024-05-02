namespace Homework3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
        }
    }
}
