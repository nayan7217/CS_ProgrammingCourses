//5 - Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.


Console.WriteLine("Enter the number seperated with coma");

string input = Console.ReadLine();

var seperatedInput = input.Split(',');

int maxNumber = int.MinValue;

for(int i = 0; i < seperatedInput.Length; i++)
{
    if (Convert.ToInt32(seperatedInput[i]) > maxNumber)
    {
        maxNumber = Convert.ToInt32(seperatedInput[i]);
    }
}
Console.WriteLine("Max number entered by you is = "+maxNumber);