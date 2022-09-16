using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Fields;

namespace CS_Fields
{
    public class Employee
    {
        public int EmpId;

        public string EmpName;
        // If I know that the field will be initialized only once then i will make it as the readonly
        public readonly List<Orders> Order = new List<Orders>();

        public Employee()
        {
            this.EmpId = 1;
            this.EmpName = "Unknown";
            Order = new List<Orders>();
            
        }
        public Employee(int empId) 
        {
            this.EmpId = empId;
        }
        public Employee(int empId, string empName) 
        {
            this.EmpId = empId;
            this.EmpName = empName;
        }

    }
}
