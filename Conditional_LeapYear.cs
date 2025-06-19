using System;

class LeapYear
{
    public static void Main()
    {
        int year, Leap;

        Console.WriteLine("Calculate if its a leap year or not!");
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter a year: ");
        year = Convert.ToInt32(Console.ReadLine());

        //This calculate the leap year. If there's a remainder, its not a leap year
        Leap = year % 4;

        //Conditional
        if (Leap == 0)
        {
            Console.WriteLine($"The {year} is a leap year!");
        }
        else
        {
            Console.WriteLine($"The {year} is not a leap year!");
        }
    }
}

/*
Calculate if its a leap year or not!
---------------------------------------
Enter a year: 2004
The 2004 is a leap year!

Calculate if its a leap year or not!
---------------------------------------
Enter a year: 2025
The 2025 is not a leap year!
*/
