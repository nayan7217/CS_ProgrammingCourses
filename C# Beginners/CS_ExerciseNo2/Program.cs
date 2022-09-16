//2 - Write a program which takes two numbers from
//the console and displays the maximum of the two.


Console.WriteLine("Enter the first NO");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second NO");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
Console.WriteLine($"Maximum no between the two no is = {maxNumber}");