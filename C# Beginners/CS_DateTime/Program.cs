// Working with DateTime


var dateTime = new DateTime(2018,12,12);

var now = DateTime.Now;

var today = DateTime.Today;

Console.WriteLine(now);

Console.WriteLine(today);

// to get the Perticular one

Console.WriteLine("Year = " + now.Year);

Console.WriteLine("Month = "+now.Month);

Console.WriteLine("Day = "+now.Year);

Console.WriteLine("Current time in Hour = "+now.Hour);

// long date string

Console.WriteLine("Long Date string " +now.ToLongDateString());

Console.WriteLine("Time = " +now.ToLongTimeString() );


// both date and time

Console.WriteLine("Both =" +now.ToString());
Console.WriteLine("yyyy - MM - dd format =" + now.ToString("yyyy-MM-dd"));




