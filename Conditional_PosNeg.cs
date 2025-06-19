using System;

class positiveNegative
{
    public static void Main()
    {
        //Variables
        int userinput;
        Console.WriteLine("Check whether positive or negative!");
        Console.WriteLine("------------------------------------");
        Console.Write("Enter an integer either positive or negative: ");
        //UserInput
        userinput = Convert.ToInt32(Console.ReadLine());

        //Conditional
        if (userinput >= 0)
        {
            Console.WriteLine($"{userinput} is positive!");
        }
        else
        {
            Console.WriteLine($"{userinput} is negative!");
        }
    }
}
