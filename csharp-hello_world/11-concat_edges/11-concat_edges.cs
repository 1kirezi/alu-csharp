using System;
class Program {
    static void Main() {
        string str1 = new string(new char[]{'o','b','j','e','c','t','-','o','r','i','e','n','t','e','d',' '}),
               str2 = new string(new char[]{'p','r','o','g','r','a','m','m','i','n','g',' '}),
               str3 = new string(new char[]{'i','n',' '}),
               str4 = new string(new char[]{'C','#'});
        Console.WriteLine(str1 + str2 + str3 + str4);
    }
}
