
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your favourite food item?");
string food = Console.ReadLine();

Console.WriteLine("Enter lucky number #1");
string number1Str = Console.ReadLine();

Console.WriteLine("Enter lucky number #2");
string number2Str = Console.ReadLine();

//Convert the two numbers to integers
int num1 = int.Parse(number1Str);
int num2 = int.Parse(number2Str);

int sum = num1 + num2;

Console.WriteLine();
Console.WriteLine("Your name is " + name + " and you like " + food);

Console.WriteLine("The sum of your two lucky numbers is " + sum);

/* 
 This 
 is
 a 
 block 
 comment!
*/
