

Console.WriteLine("Enter the hour and minuts");

string input = Console.ReadLine();
string[] inputArray = input.Split(':');



var Time = TimeSpan.Parse(Console.ReadLine());

Console.WriteLine(Time.Hours);
if (Convert.ToInt32(inputArray[0]) <00 || Convert.ToInt32(inputArray[0]) > 24)
{
    Console.WriteLine("Invalid Time");
}
else
{
    Console.WriteLine("OK");
}