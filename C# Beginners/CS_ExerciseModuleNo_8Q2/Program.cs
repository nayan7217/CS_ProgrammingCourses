//2 - Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.


string input = Console.ReadLine();

var inputArray = input.Split('-');

int[] intArray = new int[inputArray.Length];

for(int i = 0; i < intArray.Length; i++)
{
    intArray[i] = Convert.ToInt32(inputArray[i]);
}
for (int i = 0; i < intArray.Length; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] == intArray[j])
        {
            Console.WriteLine(intArray[i]);
            break;
        }
    }
}



