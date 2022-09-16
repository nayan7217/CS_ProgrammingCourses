//4 - Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".


string input = Console.ReadLine();


string newInput = input.ToLower();

string outputString = "";

outputString += Char.ToUpper(newInput[0]);
for(int i = 1; i < newInput.Length; i++)
{
    if (newInput[i]==' ')
    {
        outputString += Char.ToUpper(newInput[i + 1]);
        i++;
        continue;
    }
    outputString += newInput[i];
}
Console.WriteLine(outputString);