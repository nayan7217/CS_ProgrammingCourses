
// Time span

var timeSpan = new TimeSpan(1, 4, 7);


// Above value are given as hour minuts and second 

// if the value is not given it will take 0;


var newSpan = new TimeSpan(2, 6, 9);


var forTwoHour = new TimeSpan(2, 0, 0);

// Instead of writting the above code we can write the following code for the


var forTwoHour2 = TimeSpan.FromHours(2);

var startingTime = DateTime.Now;

var endingTime = DateTime.Now.AddHours(2);

var durationOfTime = endingTime - startingTime;
Console.WriteLine("Time span between the two value ");

Console.WriteLine(durationOfTime);

// Timespan class has some of the properties 


// we have created the object of the Timespan class in the 1st part



Console.WriteLine("Hour of the Timespan = " +timeSpan.Hours);


Console.WriteLine("Minuts of the Timespan = "+timeSpan.Minutes);

Console.WriteLine("Seconds of the Timespan = "+timeSpan.Seconds);

// To Add the Additional value to the timespan 

Console.WriteLine("By Adding the 2 hours 30 minuts and 40 second to the above timespan");

Console.WriteLine(timeSpan);
Console.WriteLine("After Adding the Hour values to the above span = " +timeSpan.Add(TimeSpan.FromHours(2)));

Console.WriteLine("After Adding the Minuts values to the above span = " +timeSpan.Add(TimeSpan.FromMinutes(30)));

Console.WriteLine("After Adding the Second value to the above span = " + timeSpan.Add(TimeSpan.FromSeconds(40)));

