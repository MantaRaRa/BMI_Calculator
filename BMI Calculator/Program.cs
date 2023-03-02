// Initaialize Vaiable

using BMI_Calculator;

Person person = new Person();

string weight, str_feet, str_inches;

double feet, inches, BMI;


// set title of program

Console.Title = "BMI Calculator";
Console.WriteLine(Console.Title);

// Welcome User
Console.WriteLine("\tWelcome to the " + Console.Title );
Console.WriteLine("I'm going to ask you a few Questions " + "and estimate your Body Mass Index.");


// User's Name
Console.Write("\nWhat's you name? ");
person.Name = Console.ReadLine();
Console.WriteLine("\nIt's a Pleasure to meet you, " + person.Name + ".");








// exit the program
Console.Write("\nPress enter to quit.");
Console.Read();



  
