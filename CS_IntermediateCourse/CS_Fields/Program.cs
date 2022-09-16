using CS_Fields;

var emp = new Employee();
Orders orders = new Orders();


Console.WriteLine("Employee Id =" + emp.EmpId);
Console.WriteLine("Employee Name =" + emp.EmpName);
emp.Order.Add(orders);
Console.WriteLine(emp.Order[0]);


var emp2 = new Employee() { EmpName = "Nayan", EmpId = 123 };