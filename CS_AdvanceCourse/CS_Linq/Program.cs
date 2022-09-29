using CS_Linq;
Employee employee = new Employee();
employee.Details();

var listOfEmployee = employee.getList();




// Get the First Employee Whose salary is 13000 
//First is used to do that

var firstEmployee = listOfEmployee.First((employee) => employee.Salary == 13000);
//Here above first Take the Deligate which is the Predicate
//Predicate is the function that return the value in true or false
// Working of first := If the value is true then it will return that value else if the value is not found then it will 
// throw the exception
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("First Employee Whose salary is 13000 ");
Console.WriteLine($"Employee Name = {firstEmployee.EmpName} Employee Salary = {firstEmployee.Salary} Employee Id = {firstEmployee.EmpNo}");


// Get the Record of Employee whole Salary are Greter than 30000
//Where
// For getting the more no of records from the IEnumerable we have to use the where condition
// It will Also take the Predicate 

var employeesWithSalaryGreatThan30000 = listOfEmployee.Where(employee => employee.Salary > 30000);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Record of Employee whole Salary are Greter than 30000");
foreach(var employees in employeesWithSalaryGreatThan30000)
{
    Console.WriteLine($"Employee Name = {employees.EmpName} Employee Salary = {employees.Salary} Employee Id = {employees.EmpNo}");

}

// Get the Last Record Whole Salary is less than 300000
// Last
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
var lastEmployeeWith30000 = listOfEmployee.Last(employee => employee.Salary < 30000);
Console.WriteLine("Last Record Whole Salary is less than 300000");
Console.WriteLine($"Employee Name = {lastEmployeeWith30000.EmpName} Employee Salary = {lastEmployeeWith30000.Salary} Employee Id = {lastEmployeeWith30000.EmpNo}");

// if Last record not exist in the above code it will crash the code hence to stop that we will use the LastOrDefault
// LastOrDefault

var lastRecordThatNotExist = listOfEmployee.LastOrDefault(employee => employee.EmpName == "Ashok");
//Console.WriteLine(" Last Record Whole Name is ashok");
//Console.WriteLine($"Employee Name = {lastRecordThatNotExist.EmpName} Employee Salary = {lastRecordThatNotExist.Salary} Employee Id = {lastRecordThatNotExist.EmpNo}");


// Skip first 20 records and take 5 records
// Take and skip are used to take or skip the record fromo the collection

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Take And Skip Demonstration");
var employeeRecord = listOfEmployee.Skip(20).Take(5);
foreach (var employees in employeeRecord)
{
    Console.WriteLine($"Employee Name = {employees.EmpName} Employee Salary = {employees.Salary} Employee Id = {employees.EmpNo}");

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Order the given Collection in Ascending Order of the Salary");

var ascendingOrderEmployee = listOfEmployee.OrderBy(employee => employee.Salary);

foreach (var employees in ascendingOrderEmployee)
{
    Console.WriteLine($"Employee Name = {employees.EmpName} Employee Salary = {employees.Salary} Employee Id = {employees.EmpNo}");

}


// Some of the Agregate Function in the LINQ


var countOfAllEmployee = listOfEmployee.Count();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"Total Count of the Employee = {countOfAllEmployee}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"Maximum Salary of the Employee");

var highestPaidEmployee = listOfEmployee.Max((employee) => employee.Salary);

Console.WriteLine($"Highest Paid Employee in the Collection is = {highestPaidEmployee}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"minimum Salary of the Employee");

var minimumPaidEmployee = listOfEmployee.Min((employee) => employee.Salary);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"Highest Paid Employee in the Collection is = {minimumPaidEmployee}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Sum of Salary of All Employee");

var sumOfEmployeesSalary = listOfEmployee.Sum((employee) => employee.Salary);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"Sum of Salary of All Employee {sumOfEmployeesSalary}");


