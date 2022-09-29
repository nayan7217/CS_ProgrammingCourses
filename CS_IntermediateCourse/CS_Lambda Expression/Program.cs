
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{

	public int rollNo{get;set;}

	public string name{get;set;}
}

class Solution
{


	static void Main(string[] args)
	{
		List<Student> details = new List<Student>() {
			    new Student{ rollNo = 5, name = "karan" },
				new Student{ rollNo = 2, name = "akash" },
				new Student{ rollNo = 4, name = "rajesh" },
				new Student{ rollNo = 3, name = "dinesh" },
				new Student { rollNo = 1, name = "abhi" },
				new Student { rollNo = 6, name = "dinesh" }
		};


		var ascendingOrderStudents = details.OrderBy(student => student.rollNo);

        Console.WriteLine("Sorted With RollNo");
		foreach(var item in ascendingOrderStudents)
        {
			Console.WriteLine($"{item.rollNo}    {item.name}");
        }


		var orderWithNameOfStudent = details.OrderBy(student => student.name);

		

        Console.WriteLine("Sorted with the Name");
		foreach (var item in orderWithNameOfStudent)
		{
			Console.WriteLine($"{item.rollNo}    {item.name}");
		}


		var dineshRecord = details.Where(student => student.name == "dinesh");

        Console.WriteLine("Accesing the perticular Name of Record ");
        foreach(var student in dineshRecord)
        {
            Console.WriteLine($"StudentRollNo = {student.rollNo} StudentName = {student.name}");
        }



	}
}
