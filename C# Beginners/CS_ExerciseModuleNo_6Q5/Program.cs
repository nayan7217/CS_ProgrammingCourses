
namespace question5
{
    class Solution
    {
        public static void Main()
        {
            bool isNotCapableString = true;

            string inputString = "";
            while (isNotCapableString)
            {
                Console.WriteLine("Enter the element of the list");
                string input = Console.ReadLine();
                if (iscount5(input))
                {
                    isNotCapableString = false;
                    inputString += input;
                }
                else
                {
                    Console.WriteLine("Length of the string is not 5");
        
                }

            } 
            
            var stringArray = inputString.Split(' ');
            List<int > numbers = new List<int>();
            for(int i = 0; i < stringArray.Length; i++)
            {
                numbers.Add(Convert.ToInt32(stringArray[i]));
            }


            numbers.Sort();
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
        }
        public static bool iscount5(String input)
        {
            int Count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    Count++;
                }
            }
            return Count == 5 ? true : false;
        }
    }
}