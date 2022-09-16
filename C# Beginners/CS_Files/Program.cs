using System.IO;

// Copy file from one location to another
// It takes two parametter source and Destination


string sourceFilePath = @"C:\Coditas\File\WorkingWithFiles\output.png";

string DestinationFilePath = @"C:\Coditas\File\WorkingWithFiles2\DestinationCopy.png";
File.Copy(sourceFilePath, DestinationFilePath,true);

Console.WriteLine("File copied successfully! ");


var fileInformation = File.ReadAllLines(sourceFilePath);
Console.WriteLine(fileInformation);

var fileInfo = new FileInfo(sourceFilePath);


fileInfo.Delete();

Console.WriteLine("File Deleted Successfully");


