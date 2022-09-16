//1 - Write a program and ask the user to enter a number.
//The number should be between 1 to 10. If the user enters a valid number,
//display "Valid" on the console. Otherwise, display "Invalid".
//(This logic is used a lot in applications where values entered into
//input boxes need to be validated.)


Console.WriteLine("Enter the number between 1 - 10");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0 && number <= 10)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}
