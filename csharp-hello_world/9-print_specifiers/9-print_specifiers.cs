using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        float number = 0.75525f;
        string tip = "tip";
        Console.WriteLine($"Percent: {number.ToString("P2", CultureInfo.GetCultureInfo("en-US"))} {tip}");
        Console.WriteLine("Currency: " + 98765.43.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
    }
}
