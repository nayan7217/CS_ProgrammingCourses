using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csConstructor;

namespace csConstructor
{
    public class Employee
    {
        public int EmpId;

        public string EmpName;

        public List<Orders> Order;

        // for the reference type we always need to initialize otherwise it will throw the error
        // object reference is not set to an instance of the object
        public Employee()
        {
            this.EmpId = 1;
            this.EmpName = "Unknown";
            Order = new List<Orders>();
            // Here I am declaring the Address Reference to the List of the class order
        }
        public Employee(int empId):this()
            // here i am calling the parameterless ctor to instantiate the list object
        {
            this.EmpId = empId;
        }
        public Employee(int empId , string empName):this()
        {
            this.EmpId= empId;
            this.EmpName = empName;
        }

    }
}
