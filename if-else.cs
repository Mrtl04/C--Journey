using System;
using System.IO.Pipes;
using System.Reflection;

class Practice_IfElse
{
    public static void Main()
    {
        int int1, int2;
        Console.WriteLine("Check if the two integers are similar!");
        Console.WriteLine("---------------------------------------\n");
        Console.Write("Input 1st number: ");
        //This convert the .Readline(), because by default its a string. So this method will convert it from string to int.
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 2nd number: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        if (int1 == int2)
        {
            Console.WriteLine($"{int1} and {int2} is equal!");
        }
        else
        {
            Console.WriteLine($"{int1} and {int2} is not equal. :(");
        }
        
    }
}

/*Check if the two integers are similar!
---------------------------------------

Input 1st number: 10
Input 2nd number: 10
10 and 10 is equal!

Check if the two integers are similar!
---------------------------------------

Input 1st number: 1
Input 2nd number: 2
1 and 2 is not equal. :(
*/
