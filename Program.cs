namespace Exercise3;

class Program
{
    static void Main(string[] args)
    {
        //Задание 3. Напишите программу которая считывает из консоли фразу и сохраняет её.
        //Затем считывает вторую фразу и выводит на экран консоли обе этих фразы.

        uint my_age;
        Console.Write("Сколько тебе лет дитя человеческое? ");
        my_age = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("твой возраст: " + my_age);
        
        string you_name;
        Console.Write("как имя твоё падаван? ");
        you_name = Console.ReadLine();
        Console.WriteLine("Да прибудет с тобой сила: " + you_name);
    }
}