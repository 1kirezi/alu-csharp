using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";

        for (int i = 0; i <= 98; i++)
        {
            output += i + " = 0x" + i.ToString("x");

            if (i != 98)
                output += "\n";
        }

        Console.Write(output);
    }
}