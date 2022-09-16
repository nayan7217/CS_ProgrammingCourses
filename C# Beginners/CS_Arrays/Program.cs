




// Arrays in C Sharp


int[] numberArray = new int[10];
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = i;
}



for (int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine(numberArray[i]);
}

Console.WriteLine("Length of the array is " +numberArray.Length);


// find the index of the perticular element in the array

var indexOfElement = Array.IndexOf(numberArray, 5);
Console.WriteLine("index of the element "+ numberArray[5] +"is " + indexOfElement);

// Array clear method setes the range of the value 0 in the object




Array.Clear(numberArray, 2, 5);
for(int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine(numberArray[i]);
}

// Copy method of the array

int[] intArray = new int[3];
Array.Copy(numberArray, intArray, 3);
for(int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("New Array element are" + intArray[i]);
}

string[] stringArray = new string[10];

for (int i = 0; i < numberArray.Length; i++)
{
    stringArray[i] = $"{i}. String Array";
}

for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine(stringArray[i]);
}



// Jaged Array

// They are the array in the other array

;
var numberArray2 = new int[3][];

numberArray2[0] = new int[2];
numberArray2[1] = new int[3]; 
numberArray2[2] = new int[4];

var numArray3 = new int[7] { 232, 2454, 7565, 345, 6454, 3434, 343 };


// Sort method of the array

Array.Sort(numArray3);


for(int i = 0; i < numArray3.Length; i++)
{
    Console.WriteLine(numArray3[i]);
}
