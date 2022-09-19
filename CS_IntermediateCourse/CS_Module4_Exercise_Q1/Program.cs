using CS_Module4_Exercise_Q1;



try
{
    Stack stackobject = new Stack();
    string choice = "run";
    do
    {
        Console.WriteLine("1. Push Object to the Stack");
        Console.WriteLine("2. Pop Object from the Stack");
        Console.WriteLine("3. Clear Object from the Stack");
        Console.WriteLine("4. Print the Stack");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Employee employee = new Employee();
                Console.WriteLine("Enter the following Details to push in the Stack");
                Console.WriteLine("Enter the Employee Id");
                employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name");
                employee.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter the Employee Designation");
                employee.EmployeeDesignation = Console.ReadLine();

                stackobject.Push(employee);
                break;
            case 2:
                var popedObject = (Employee)stackobject.Pop();
                Console.WriteLine($"Employee Id = {popedObject.EmployeeId}");
                Console.WriteLine($"Employee Name = {popedObject.EmployeeName}");
                Console.WriteLine($"Employee Designation = {popedObject.EmployeeDesignation}");
                Console.WriteLine("Above Object is Poped from the Stack");
                break;
            case 3:
                stackobject.Clear();
                Console.WriteLine("Stack is Cleared");
                break;
            case 4:
                stackobject.Print();
                break;
        }
        Console.WriteLine("Enter exit to Stop the Execution Otherwise type any Key");
        choice = Console.ReadLine();


    } while (choice != "exit");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}