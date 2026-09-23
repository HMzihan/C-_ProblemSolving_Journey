using System;
using System.Runtime.InteropServices;

class Pr2
{
    public static string first_year(string xl)
    {
        return xl.Length > 1 
            ? xl.Substring(xl.Length - 1) + xl.Substring(1,xl.Length - 2) + xl.Substring (0,1) :
         xl;
    }

    static void Main()
    {
        Console.WriteLine(first_year("w3resource"));
        Console.WriteLine(first_year("Python"));
        Console.WriteLine(first_year("x"));
    }
} 