using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(String[] args)
    {
        //For Looping
        /*
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        */

        //Happy new year
        /*
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Happy New Year!");
        */

        //Forech loopings
        /*
        foreach (var i in Enumerable.Range(0, 10))
        {
            Console.WriteLine(i);
        }
        */

        //Working with dict
        /*
        var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 } };
        foreach (var (key, value) in dict)
        {
            Console.WriteLine($"{key}:{value}");
        }
        */

        //While Loop
        /*
        int num = 0;
        while (num < 10)
        {
            num++;
            Console.WriteLine(num);
        }
        */
        /*
        int num = 0;
        do
        {
            num++;
            Console.WriteLine(num);
        }
        while (num < 10);
        */
    }
}
