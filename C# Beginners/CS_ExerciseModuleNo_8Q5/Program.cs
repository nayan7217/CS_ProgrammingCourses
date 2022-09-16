//5 - Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.So, if the user enters "inadequate", the program should display 6 on the console.

Console.WriteLine("Enter the string to cheack the count of vowels");
string input = Console.ReadLine();


int countOfVowels = 0;
for(int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
    {
        countOfVowels++;
    }
}
Console.WriteLine($"Count of the vowel is {countOfVowels}");