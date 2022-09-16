

// Basically the enums are used to declare the multiple constant 
// if the program contains more no of the constants then  we can use the enum 
// instead of declaring one by one


namespace CS_Enums
{


    public enum DaysOfWeak
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public static class Enums
    {
        public static void Main()
        {
            Console.WriteLine(DaysOfWeak.Sunday);
            // use the typecasting to get the value of the Day
            Console.WriteLine((int)DaysOfWeak.Sunday);


            var DayNoOfWeak = 5;


            // type cast any no to find the details of the given indivisual



            Console.WriteLine((DayOfWeek)DayNoOfWeak)

        }
    }
}

