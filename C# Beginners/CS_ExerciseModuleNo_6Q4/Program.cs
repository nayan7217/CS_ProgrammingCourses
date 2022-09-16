//4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered

List<int> lst = new List<int>();



while (true)
{
    Console.WriteLine("Enter the number or Quit");
    string input = Console.ReadLine();
    if (input == "Quit")
    {
        break;
    }
    else
    {
        lst.Add(Convert.ToInt32(input));
    }
}
List<int> noDupes = lst.Distinct().ToList();

foreach(var item in noDupes)
{
    Console.WriteLine(item);
}