using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";

        for (int i = 1; i < 100; i++)
        {
            if ((i / 10) < (i % 10))
            {
                output += i.ToString("D2");

                if (i != 89)
                    output += ", ";
            }
        }

        Console.WriteLine(output);
    }
}
