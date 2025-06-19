/*
11. Write a C# Sharp program to calculate the root of a quadratic equation.
Test Data :
Input the value of a : 1
Input the value of b : 5
Input the value of c : 7
Expected Output :
Root are imaginary;
No Solution.

Formula: x = (-b ± √(b² - 4ac)) / 2a. 
*/

using System;

class rootQuadEq
{
    public static void Main()
    {
        //Variables
        int a, b, c;
        double discriminant, x1, x2;
        Console.WriteLine("==========================================");
        Console.WriteLine("Calculate the root of a quadratic equation");
        Console.WriteLine("==========================================\n");
        //User Input
        Console.Write("Input Value of a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Value of b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Value of c: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("==========================================");

        //Formula for (b² - 4ac) in x = (-b ± √(b² - 4ac)) / 2a.
        discriminant = (b * b - 4 * a * c);

        //The discriminant is also the basis for the conditional statement because it tells what type of root a quadratic equation is
        /*
        d > 0 - Two real and different
        d = 0 - One real root
        d < 0 - No real root or imaginary
        */

        if (discriminant == 0)
        {
            Console.WriteLine("Both roots are equal.");
            //discriminant is removed here because ±discriminant is equal to 0.
            x1 = (-b / 2.0 * a);
            x2 = x1;
            Console.WriteLine("==========================================");
            Console.WriteLine($"The first root(root1): {x1}");
            Console.WriteLine($"The second root(root2): {x2}");

        }
        else if (discriminant > 0)
        {
            Console.WriteLine("Both roots are real and different");
            //Here the discrimiant is included to the formula because it was not equal to 0 but greater than 0.

            //Since the formula include ±, two equation is needed
            x1 = (-b + Math.Sqrt(discriminant) / (2.0 * a));
            x2 = (-b - Math.Sqrt(discriminant) / (2.0 * a));
            Console.WriteLine("==========================================");
            Console.WriteLine($"The first root(root1): {x1}");
            Console.WriteLine($"The second root(root2): {x2}");

        }
        else
        {
            //When the discriminant is less than 0(Negative) there will be no solution because you have to get the square root of the negative number
            //which isn't possible in real numbers.
            Console.Write("Roots are imaginary;\nNo Solution. \n\n");
        }

    }
}

/*
Calculate the root of a quadratic equation
==========================================

Input Value of a: 1 
Input Value of b: -2
Input Value of c: 1
==========================================
Both roots are equal.
The first root(root1): 1
The second root(root2): 1


*/
