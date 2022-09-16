//1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.



string input = Console.ReadLine();

var inputString = input.Split(' ');

var countOfLikes = inputString.Length;

if (countOfLikes > 2)
{
    Console.WriteLine($"{inputString[0]},{inputString[1]} and {countOfLikes-2} other like your post.");
}
else if(countOfLikes == 2)
{
    Console.WriteLine($"{inputString[0]},{inputString[1]} like your post.");

}
else if (countOfLikes == 1)
{
    Console.WriteLine($"{inputString[0]} like your post.");

}