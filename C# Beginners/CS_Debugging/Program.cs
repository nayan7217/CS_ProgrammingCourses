namespace CS_Debugging
{

    class Solution
    {
        public static void Main()
        {
            List<int> lst = new List<int> { 2, 34, 2244, 4344, 233, 454 };

            int MaximumValue = findMax(lst);

            Console.WriteLine(MaximumValue);
        }
        public static int findMax(List<int> lst)
        {
            int Max = int.MinValue;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > Max)
                {
                    Max = lst[i];
                }
            }
            return Max;
        }
    }
}