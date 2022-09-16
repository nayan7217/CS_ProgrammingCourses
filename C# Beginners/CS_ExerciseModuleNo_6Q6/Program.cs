//1 - Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".


string input = Console.ReadLine();

var inputArray = input.Split('-');

int[] intArray = new int[inputArray.Length];
int diference = intArray[1] - intArray[0];
for (int i = 0; i < intArray.Length-1; i++)
{
    if (intArray[i + 1] - intArray[i] != diference)
    {
        Console.WriteLine("Non Consecutive");
        return;
    }
}
Console.WriteLine("Consecutive");

