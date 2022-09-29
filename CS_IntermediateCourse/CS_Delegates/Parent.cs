using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Delegates;

namespace CS_Delegates
{
    internal class Parent
    {
        public delegate void MethodHandler(int x, int y);

        public delegate int MethodHandler2(int x, int y);
        public void Calculator(int a, int b , MethodHandler methodDelegate)
        {
           methodDelegate(a,b);
        }
        public void Mudulus(int a ,int b)
        {
            Console.WriteLine($"Modulus Of the no is = {a%b}");
            return;
        }


    }
}
