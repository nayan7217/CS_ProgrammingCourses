using CS_Methods;


// CS Methods

// Signatur of the method
// Name type and no of the parameter

// Overloading = Method with same name and different parameter




Console.WriteLine("Addition of the two no is " + Solution.Add(2,3));
Console.WriteLine("Addition of the three no is " + Solution.Add(2, 3,4));
Console.WriteLine("Addition of the multiplee no is " + Solution.Add(2, 3,4,5,6,7,10));



// ref = Pass the reference to the method means changes done in the method that willl happen to passing parameter


// out = the value 

Solution sObject = new Solution(10,20);
sObject.Move(30, 40);
Console.WriteLine("First Value" + sObject.X);
Console.WriteLine("Second Value "+sObject.Y);

Solution sn = new Solution(50, 40);
sObject.Move(sn);

Console.WriteLine("After Changing the valules");

Console.WriteLine("First Value" + sObject.X);
Console.WriteLine("Second Value " + sObject.Y);

