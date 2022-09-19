using csConstructor;
namespace CS_Constructor
{


    public class Solution
    {
        public static void Main()
        {
            var emp = new Employee();
            Orders orders = new Orders();
            // If we have created the parameterized constructor and 
            // we dont have the parameterless ctor then it will throw the error

            Console.WriteLine("Employee Id =" + emp.EmpId);
            Console.WriteLine("Employee Name =" + emp.EmpName);
            emp.Order.Add(orders);
            Console.WriteLine(emp.Order[0]);
            // object initialization
            // Here I have initialized the object

            var emp2 = new Employee() { EmpName = "Nayan", EmpId = 123 };


        }
    }
}