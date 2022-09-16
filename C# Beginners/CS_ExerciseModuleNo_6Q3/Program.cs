//3 - Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


int[] inputArray = new int[5];

for(int i = 0; i < 5; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    while (inputArray.Contains(input))
    {
        Console.WriteLine("Error Enter Correct No");
        input = Convert.ToInt32(Console.ReadLine());
    }
    inputArray[i] = input;
}
Array.Sort(inputArray);
Console.WriteLine("Sorted Array -");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(inputArray[i]);
}