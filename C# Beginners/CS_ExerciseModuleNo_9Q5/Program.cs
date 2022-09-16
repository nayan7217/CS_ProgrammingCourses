

string sourceFilePath = @"C:\Coditas\Files2\fileclass.txt";


var fileString = File.ReadAllText(sourceFilePath);

Console.WriteLine(fileString);

var fileStringArray = fileString.Split(" ");

Console.WriteLine("Count of the word in the file is " +fileStringArray.Length);




