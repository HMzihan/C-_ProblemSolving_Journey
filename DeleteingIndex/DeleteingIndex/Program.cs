using System;

class Xi
{

    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }

    static void Main()
    {
        Console.WriteLine(remove_char("w3resource", 3));
        Console.WriteLine(remove_char("w3resource", 2));
        Console.WriteLine(remove_char("w3resource", 4));
    }
}