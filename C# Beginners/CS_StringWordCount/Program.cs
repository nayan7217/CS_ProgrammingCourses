// Count the word of the given string


string statement = "India is my Country And all indians are, my brother and siter. I Love India.";


// find the lenght of the string
const int MaxLenght = 10;


 int lengthOfString = statement.Length;



if (lengthOfString < MaxLenght)
{
    Console.WriteLine(statement);
}
else
{
    var Words = statement.Split(' ');


    foreach(var item in Words)
    {
        Console.Write(item +" ");

    }
}