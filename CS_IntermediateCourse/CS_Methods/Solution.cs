using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Methods
{
    public  class Solution
    {
        public int X;

        public int Y;
        public Solution(int x , int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static int Add(int a, int b)
        {
            return a + b ;
        }
        public static int Add(int a, int b ,int c)
        {
            return a + b + c;
        }
        // Here I have created the example of the method overloading
        // but this example is worst if the no of parameter are more
        // Param -Param is used when there are multiple parameter passed to the method 

        public static int Add(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum+=numbers[i];
            }
            return sum;
        }

        public static void Add(int number)
        {
            number += 10;
            return;
        }

        public void Move(int x ,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Solution newObj)
        {
            //this.X = newObj.X;
            //this.Y = newObj.Y;
            // Instead of writing the method for the two different time

            // bu if the newObj is null then it will crash to stop tha


            //Defensive Programming
            if (newObj == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newObj.X,newObj.Y);
        }
    }
}
