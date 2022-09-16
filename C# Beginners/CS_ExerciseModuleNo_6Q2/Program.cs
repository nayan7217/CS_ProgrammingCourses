//2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.


string userName = Console.ReadLine();
char[] userNameArray = new char[userName.Length];

for(int i = 0; i < userName.Length; i++)
{
    userNameArray[i] = userName[i];
}
Array.Reverse(userNameArray);

string newUserName = "";
for(int i = 0; i < userNameArray.Length; i++)
{
    newUserName+=userNameArray[i];
}
Console.WriteLine(newUserName);