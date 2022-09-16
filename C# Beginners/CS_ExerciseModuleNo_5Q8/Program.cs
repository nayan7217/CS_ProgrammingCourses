//4 - Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)


Random randomNO = new Random();

int randomNumber = randomNO.Next(1, 10);

Console.WriteLine("Enter your choice to guess");
int choice = Convert.ToInt32(Console.ReadLine());


if (choice == randomNumber)
{
    Console.WriteLine("You Win !!!!!!!!!!");
}
else
{
    Console.WriteLine($"You Lost !!!!!!!!! Random No was {randomNumber}");
}