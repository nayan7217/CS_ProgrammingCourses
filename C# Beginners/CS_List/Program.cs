
List<int> integerList = new List<int>() { 123,23334,223,2345,223,645};

// We can Add item by Add method


integerList.Add(2000);
integerList.Add(543);


integerList.AddRange(new int[4] { 1,2,3,4});

foreach(var integer in integerList)
{
    Console.WriteLine(integer);
}

// find the index of the method


Console.WriteLine("Index of the integer 2 is = " + integerList.IndexOf(2));

// finding the last index of the element



Console.WriteLine("Last Index of the integer 223 is = " + integerList.LastIndexOf(223));


// Removing the element of the array

integerList.Remove(223);
Console.WriteLine("After Removing the item 223");

foreach (var item in integerList)
{
    Console.WriteLine(item);
}