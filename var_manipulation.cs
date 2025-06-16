//LEARNING VARIABLES MANIPULATION
//-----------------------------------------------------------------------------------------------------------
//String Concatenation
string greet = "Hello";
string name = "Mykel";

//-----------------------------------------------------------------------------------------------------------
Console.WriteLine("Hello, " + name);
//-----------------------------------------------------------------------------------------------------------
//String interpolation

Console.WriteLine($"{greet}, {name}");

string word1 = "Chicken";
string word2 = "Water";
Console.WriteLine($"My Friends Loves eating {word1} and loves drinking {word2}");
//-----------------------------------------------------------------------------------------------------------
//Using Lenght(.Lenght) - Count the number of letter in a string or count the number or variable in an arrray 

Console.WriteLine($"The word {word1} has {word1.Length} letters!");
//-----------------------------------------------------------------------------------------------------------
//Trimming(.TrimStart(), .TrimEnd(), .Trim())

string greeting = "      Hello!     ";
Console.WriteLine($"[{greeting}]"); //[      Hello!     ]

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]"); //[Hello!     ]

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]"); //[      Hello!]

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); //[Hello!]

string phrase = "  Hello, I'm Mykel!      ";
string trimmedPhrase = phrase.Trim();
Console.WriteLine($"[{trimmedPhrase}]"); //[Hello, I'm Mykel!]
//-----------------------------------------------------------------------------------------------------------
//Replace (.Replace) - Replace the content of the certain part of the variable

string name1 = "Mykel";
//                  oldchar, newchar
name1 = name1.Replace("Mykel", "Robert");
Console.WriteLine($"{name1}");

//-----------------------------------------------------------------------------------------------------------
//Caps(.ToUpper(), .ToLower()) - To make the string Capital or Lower

string noise = "Shout";
Console.WriteLine(noise.ToUpper());//SHOUT
Console.WriteLine(noise.ToLower());//shout
//-----------------------------------------------------------------------------------------------------------


//SEARCH(.Contains())
string lyrics = "I should have clipped her wings and made her mine";
Console.WriteLine(lyrics.Contains("clipped"));//If the word is in the string it will display "True"
Console.WriteLine(lyrics.Contains("Eternity"));//Other wise, "False"

//Similar Method:
Console.WriteLine(lyrics.StartsWith("I")); //True
Console.WriteLine(lyrics.StartsWith("You")); //False
Console.WriteLine("");
Console.WriteLine(lyrics.EndsWith("mine")); //True
Console.WriteLine(lyrics.EndsWith("yours")); //False
