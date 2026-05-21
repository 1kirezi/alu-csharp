using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-10000, 10001);
        int lastDigit = number % 10;

        if (lastDigit > 5)
            Console.WriteLine($"The last digit of {number} is {lastDigit} and is greater than 5");
        else if (lastDigit == 0)
            Console.WriteLine($"The last digit of {number} is {lastDigit} and is 0");
        else
            Console.WriteLine($"The last digit of {number} is {lastDigit} and is less than 6 and not 0");
    }
}
