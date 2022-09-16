namespace refVSValue
{
    class example
    {
        public int Salary { get; set; }
    }
    class Solution
    {
        public static void Main()
        {
            int number = 30;
            Console.WriteLine(number);
            add1000(number);
            Console.WriteLine(number);
            example ex = new example();
            ex.Salary = 100000000;
            Console.WriteLine(ex.Salary);
            addBonus(ex);
            Console.WriteLine(ex.Salary);
        }
        public static void add1000(int number)
        {
            number += 100;
            return;
        }
        public static void addBonus(example ex)
        {
            ex.Salary += 20000;
            return;
        }


    }
}