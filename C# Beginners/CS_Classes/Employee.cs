using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Classes
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }


        public void DisplayData()
        {
            Console.WriteLine($"Name of the Employee = {EmpName} with id {EmpId}");

        }
    }
}
