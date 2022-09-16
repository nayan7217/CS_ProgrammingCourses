

string string1 = "India is my country";

string string2 = "All Indians are my bother and sister";

Console.WriteLine(string1);

Console.WriteLine(string2);

string concatinatedString = string1 + "   "+string2;

Console.WriteLine(concatinatedString);

concatinatedString += " "+ string1 + "   " + string2;

Console.WriteLine(concatinatedString);


for(int i = 0; i < concatinatedString.Length; i++)
{
    Console.WriteLine(concatinatedString[i]);
}


// @ is used to neglate the / in the string



//String Methods

// Substring Method


string country = string1.Substring(0, 5);

Console.WriteLine(country);


// Cheack if the string is empty it will return the boolena value in the return type

Console.WriteLine(String.IsNullOrEmpty(country));

//Split Method
// It well split the string according the given condition

string[] arrayOfString1 = string1.Split(' ');

Console.WriteLine("Array made with the string1"); ;
for(int i = 0; i < arrayOfString1.Length; i++)
{
    Console.WriteLine(arrayOfString1[i]);
}
