// Working with Path class


string sourceFilePath = @"C:\Coditas\File\WorkingWithFiles\output.png";


var extensionOfFile = Path.GetExtension(sourceFilePath);

Console.WriteLine(extensionOfFile);

Console.WriteLine("With out . index");


var indexOfDot = extensionOfFile.IndexOf('.');

var normalExtension = extensionOfFile.Substring(indexOfDot+1);

Console.WriteLine(normalExtension);


Console.WriteLine("Name of the file "+Path.GetFileName(sourceFilePath));

Console.WriteLine("Name of the file Without Extenstion " +Path.GetFileNameWithoutExtension(sourceFilePath));