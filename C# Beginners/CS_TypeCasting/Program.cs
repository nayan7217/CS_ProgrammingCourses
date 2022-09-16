byte number = 2;


Console.WriteLine("number "+number);

int intNumber = number;


Console.WriteLine("int Number" +intNumber);

// here thee is no data loss hence it will done automatically


//000000001
//000000000000000000000000000000000001;

byte byteNo = number;


// there is the loss of the data


// Explicite Casting


int longNumber = 12435;


byte byteNo2 = (byte)longNumber;

//string to int not posible by explicite casting

// we use convert keyword


string noPlate = "7217";

Console.WriteLine("No Plate" +noPlate);

int integerNoPlate = Convert.ToInt32(noPlate);


Console.WriteLine("NO plate in the Integer" +integerNoPlate);

// parse method

// it take the string and convert the string to the integer type



// use the try and catch block to handle the expression

try
{
    byte byteNoPlate = Convert.ToByte(noPlate);
    Console.WriteLine(byteNoPlate);

}
catch (Exception)
{
    Console.WriteLine("The Expressing occurs: ");
}

