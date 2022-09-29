// Delegates in C#
using CS_Delegates;
using System.Linq;

Parent parentClass = new Parent();
Methods method = new Methods();


//parentClass.Calculator(100, 10);
// We are not able to access the delegate by using thhe instance of the class
// We have to Use the Method name to access the Delegate

Parent.MethodHandler methodHandler = method.Addition;
methodHandler += method.Substraction;
methodHandler += method.Multiplicatin;
methodHandler += method.Division;
methodHandler += parentClass.Mudulus;



Parent.MethodHandler2 methodHandler2 = new Parent.MethodHandler2((x, y) => x + y);
int result =  methodHandler2(10, 20);
Console.WriteLine(result);

// now suppose we must need to add the diffent operation to perform on the number
// then we dont need to deploye the app once again we can simply do by just Adding 
// Another method to the delegate;



parentClass.Calculator(100, 10, methodHandler);

int[] numbers = new int[] { 5, 2, 310, 40, 54, 35 };


int CountNoDivisibleBy5 = numbers.Count(x => x%5==0);


var newNumbers = numbers.Where(x => x > 4);

