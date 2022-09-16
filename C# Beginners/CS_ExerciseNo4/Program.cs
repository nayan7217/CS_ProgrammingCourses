//4-Your job is to write a program for a speed camera.
//For simplicity, ignore the details such as camera, sensors,
//etc and focus purely on the logic. Write a program that asks the user
//to enter the speed limit. Once set, the program asks for the speed of a
//car. If the user enters a value less than the speed limit, program should
//display Ok on the console. If the value is above the speed limit, the program should
//calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit
//points should be incurred and displayed on the console. If the number of demerit points is above
//12,the program should display License Suspended.

namespace CS_Exercise
{
    public class Solution
    {
        public static void Main()
        {

            Console.WriteLine("Enter the speed limit of the Vehicle");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car");
            int speedOfCar = Convert.ToInt32(Console.ReadLine());

            if (speedOfCar <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demerit = CalculateDemerit(speedOfCar, speedLimit);
                if (demerit > 12)
                {
                    Console.WriteLine("Licence Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points = "+demerit );
                }
            }

        }
        public static int CalculateDemerit(int speed,int speedLimit)
        {
            int aboveSpeed = speed - speedLimit;
            int demerit = aboveSpeed / 5;
            return demerit;
        }
    }

}