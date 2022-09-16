using System.IO;



string sourceFilePath = @"C:\Coditas\File\WorkingWithFiles\NewDirectory";
Directory.CreateDirectory(sourceFilePath);

Console.WriteLine("Directory Created Successfully");

Directory.Delete(sourceFilePath,true);

Console.WriteLine("Directory Deleted Successfully");


var DirectoriesOfDirectory = Directory.GetDirectories(@"C:\Coditas");


Console.WriteLine("Directorys of the given path are = ");
foreach (var  item in DirectoriesOfDirectory)
{
    Console.WriteLine(item);
}

var filesOfDirectory = Directory.GetFiles(@"C:\Coditas","*",SearchOption.AllDirectories);

Console.WriteLine(" Text File of the directories are");

foreach (var item in filesOfDirectory)
{
    Console.WriteLine(item);
}
Directory.CreateDirectory(sourceFilePath);

Console.WriteLine("source directory exist or not =" +Directory.Exists(sourceFilePath));


Console.WriteLine("source directory exist or not =" + File.Exists(sourceFilePath));

