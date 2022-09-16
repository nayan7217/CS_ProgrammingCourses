//2 - Write a program and continuously ask the user to enter a number or "ok" to
//exit. Calculate the sum of all the previously entered
//numbers and display it on the console.


int sumOfNumber = 0;



while (true)
{
    Console.WriteLine("Enter the number or OK");
    string input = Console.ReadLine();
    if(input == "ok")
    {
        break;
    }
    else
    {
        sumOfNumber+=Convert.ToInt32(input);
    }
}
Console.WriteLine("The sum of entered number is = " +sumOfNumber);