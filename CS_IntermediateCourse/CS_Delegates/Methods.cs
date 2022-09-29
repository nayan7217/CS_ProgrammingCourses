using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Delegates
{
    internal class Methods
    {
        public void Addition(int a , int b)
        {
            Console.WriteLine($"Addition = {a+b}");
            return;
        }
        public void Substraction(int a , int b)
        {
            Console.WriteLine($"Substraction = {a-b}");

        }
        public void Multiplicatin(int a , int b)
        {
            Console.WriteLine($"Multiplication = {a*b}");
        }
        public void Division(int a, int b)
        {
            Console.WriteLine($"Division = {a/b}");
        }
    }
}
