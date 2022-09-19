using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Module4_Exercise_Q1;

namespace CS_Module4_Exercise_Q1
{
    public class Stack
    {
        List<object> stackList = new List<object>();

        public void Push(object obj)
        {
            stackList.Add(obj);
        }
        public object Pop()
        {
            if(stackList.Count != 0)
            {
                var popedObject = stackList[stackList.Count - 1];
                stackList.Remove(stackList[stackList.Count - 1]);
                return popedObject;
            }
            else
            {
                throw new InvalidOperationException("The Stack is Already Empty");
            }
       
        }
        public void Clear()
        {
            stackList.Clear();
            return;
        }
        public void Print()
        {
            foreach(Employee obj in stackList)
            {
                Console.WriteLine($"Employee Name = {obj.EmployeeName}");
            }
        }
    }
}
