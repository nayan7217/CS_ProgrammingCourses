

string sourceFilePath = @"C:\Coditas\Files2\fileclass.txt";


var fileString = File.ReadAllText(sourceFilePath);

Console.WriteLine(fileString);

Console.WriteLine("no of the character in the string are "+fileString.Length);


