using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-100, 101);

        if (number > 0)
            Console.WriteLine($"{number} is positive");
        else if (number < 0)
            Console.WriteLine($"{number} is negative");
        else
            Console.WriteLine($"{number} is zero");
    }
}
