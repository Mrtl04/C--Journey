using System;

class if_else2
{
    public static void Main()
    {
        //Variables
        int userintput, remainder;

        Console.WriteLine("Check if the integer is odd or even!");
        Console.WriteLine("--------------------------------------");
        Console.Write("Input an integer: ");
        //User Input
        userintput = Convert.ToInt32(Console.ReadLine());

        //Calculation 
        remainder = userintput % 2;
        if (remainder == 0)
        {
            Console.WriteLine($"{userintput} is an even number!");
        }
        else
        {
            Console.WriteLine($"{userintput} is an odd number!");
        }
   } 
}

/*
Check if the integer is odd or even!
--------------------------------------
Input an integer: 1
1 is an odd number!

Check if the integer is odd or even!
--------------------------------------
Input an integer: 10
10 is an even number!
*/
