//1 - Write a program to count how many numbers between 1 and 100 are divisible
//by 3 with no remainder. Display the count on the console.

int countOfNumber = 0;

for(int number = 1; number <= 100; number++)
{
    if(number % 3 == 0)
    {
        countOfNumber++;
    }
}
Console.WriteLine("The no divisible by 3 from 1 to 100 are = " +countOfNumber);