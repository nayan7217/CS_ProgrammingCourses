//3 - Write a program and ask the user to enter the width
//and height of an image. Then tell if the image is landscape or portrait.


Console.WriteLine("Enter the height of the Image");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Width of the Image");
int width = Convert.ToInt32(Console.ReadLine());

if (height > width)
{
    Console.WriteLine("Portait");
}
else
{
    Console.WriteLine("LandScape");
}