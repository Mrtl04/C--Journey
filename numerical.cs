//Working with Numerical
//INTEGERS:
int a = 18;
int b = 6;

//Addition
int c = a + b;
//Subtraction
int c1 = a - b;
//Multiplication
int c2 = a * b;
//Division
int c3 = a / b;

Console.WriteLine($"The addition of {a} and {b} is {c}\n"); //24
Console.WriteLine($"The substraction of {a} and {b} is {c1}\n"); //12
Console.WriteLine($"The multiplication of {a} and {b} is {c2}\n"); //108
Console.WriteLine($"The division of {a} and {b} is {c3}\n"); //3

//Using Parenthese to perform first other operations
int d = (a + b) * c;
Console.WriteLine(d); //576
int d1 = (a + b) * 2 - (a + 10) / (2 * 2);
Console.WriteLine(d1); //41

//Modulo(%) - Remainder of the equation
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}"); //quotient: 3
Console.WriteLine($"remainder: {e}"); //remainder: 2

//Using minimum and maximum of the integers
int min = int.MinValue;
int max = int.MaxValue;
Console.WriteLine($"The minimum value of integers is {min} and the maximum is {max}"); //The minimum value of integers is -2147483648 and the maximum is 2147483647

int what = max + 3;
int when = min + 2;
Console.WriteLine($"An Example of overflow of adding 3 to the max: {what}"); //An Example of overflow of adding 3 to the max: -2147483646
Console.WriteLine($"An Example of overflow of adding 2 to the min: {when}"); //An Example of overflow of adding 2 to the min: -2147483646

/*
The output is negative because the after adding the value to the max value it will now wrap around back to the minimum value of the integers.
So basically:
2147483647(Max Value) + 1 = -2147483648(Wrap to min)
2147483647(Max Value) + 2 = -2147483647
2147483647(Max Value) + 3 = -2147483646

On the other hand
-2147483648(Min Value) + 1 =  -2147483647
-2147483648(Min Value) + 2 =  -2147483646

To conclude, when the integers exceed the maximum value, it will wrap back to the minimum value.
On the other hand, when you add to the minimum value it will just continue to add in until you
get the maximum value then same process
*/

//To fix this use long
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c) //4100000000
/*
  This makes the variable a and b which doesn't have enought storage,
  converts the two variable into long, which has more bit or storage than integers.
  */

//DOUBLE - represent double-precision floating point number. 
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d); //4.5

double a1 = 25;
double b1 = 54;
double c1 = 23;
double d1 = (a1 + b1) / c1;
Console.WriteLine(d1); //3.4347826086956523

double max = double.MaxValue; //1.7976931348623157E+308
double min = double.MinValue; //-1.7976931348623157E+308
Console.WriteLine($"The max value of double is {max} and the minimum value is {min}"); // The max value of double is 1.7976931348623157E+308 and the minimum value is -1.7976931348623157E+308

//Rounding Errors
double third = 1.0 / 3.0;
Console.WriteLine(third); //0.3333333333333333(double has limited precision (about 15-17 digits), so it approximates the value.)

//DECIMAL - Smaller range than double but more precise
decimal max = decimal.MaxValue; //79228162514264337593543950335
decimal min = decimal.MinValue; //-79228162514264337593543950335
Console.WriteLine($"The maximum value of the decimal is {max} and the minimum is {min}"); //The maximum value of the decimal is 79228162514264337593543950335 and the minimum is -79228162514264337593543950335

//Comparision of the two
double a1 = 1.0;
double b1 = 3.0;
double c1 = a1 / b1; //Using double = 0.3333333333333333
Console.WriteLine($"Using double = {c1}");

//Using the suffix M indicate that the constant should use decimal
decimal a2 = 1.0M; 
decimal b2 = 3.0M;
decimal c2 = a2 / b2; //Using decimal = 0.3333333333333333333333333333
Console.WriteLine($"Using decimal = {c2}");


