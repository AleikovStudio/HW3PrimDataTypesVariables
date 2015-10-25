using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World!";
        object both = (a + " " + b);
        
        Console.WriteLine(both);

        string c = (string)both;
        Console.WriteLine(c);
    }
}