// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Exercise 1.4!");

int hours = DateTime.Now.Hour;
int minutes = DateTime.Now.Minute;
int seconds = DateTime.Now.Second;

Console.WriteLine("The current time is " + hours + ":" + minutes + ":" + seconds);

//Alternative solution

//First get a snapshot(copy) of the current time
DateTime currentDateTime = DateTime.Now;

//Then extract the values from this snapshot 
int hours2 = currentDateTime.Hour;
int minutes2 = currentDateTime.Minute;
int seconds2 = currentDateTime.Second;

Console.WriteLine("The current time is " + hours2 + ":" + minutes2 + ":" + seconds2);
