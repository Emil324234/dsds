
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);

        Console.WriteLine("Угадай число");
        Console.WriteLine("Загадано число от 0 до 100. Угадай.");

        int lyboechislo;
        do
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out lyboechislo))
            {
                Console.WriteLine("Пожалуйста, введите целое число.");
                continue;
            }

            if (lyboechislo < randomNumber)
            {
                Console.WriteLine("Рандомное число больше");
            }
            else if (lyboechislo > randomNumber)
            {
                Console.WriteLine("Рандомное число меньше");
            }
        } while (lyboechislo != randomNumber);

        Console.WriteLine("Ура", randomNumber);
        Console.WriteLine("Выход");
        Console.ReadKey();
    }
}