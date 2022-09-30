namespace CS_ExtensionMethods
{
    class Solution
    {
        public static void Main()
        {
            // Extension Methods


            // Extension Methods are used when we want to add some methods in the class and we are not able to derive that class
            // to add some methods for example class is sealed then we are not able to inherit that class hence we use the 
            //Extension method

            // To Extend the class we have to create one Static class and The name of the class should be the 
            // ClassName followed by the Extension Keyword

            // After that we can create  the method and fro that method the first parameter should be 
            // this className obj
            // other will be the next parameter according to the need




            string myFullname = "Nayan Rajendra Ranjane";

            // Above string class is sealed class
            // there is no method to get my surname from the the above string class

            var surname = myFullname.GetSurname();
         

            Console.WriteLine($"My surname is {surname}");

            // int is  the sealed class and it doen't have the method for adding another number 
            int digit = 43453;

            var sumOfDigit = digit.Add(5);
           
            Console.WriteLine($"Addition of the number is {sumOfDigit}");



        }
        
    }
    public static class StringExtension
    {
        public static string GetSurname(this string str)
        {
            int countSpace = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    countSpace++;
            }
            if (countSpace == 2)
            {
                var wordArray = str.Split(' ');
                return wordArray[2];
            }
            else
                return "String Cannot Be Processed";

        }

    }
    public static class intExtension
    {
        public static int Add(this int firstNumber,int SecondNumber)
        {
            return firstNumber + SecondNumber;
        }
    }
}