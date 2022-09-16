// Ternary Operator


int firstNo = 123;

int secondNo = 543;

int thirdNo = 789;

int bigNo = (firstNo>secondNo)? firstNo : secondNo;

Console.WriteLine(bigNo);

int bigNo2 = (firstNo>secondNo)? (firstNo>thirdNo)?firstNo:thirdNo : (secondNo>thirdNo)?secondNo:thirdNo;

Console.WriteLine(bigNo2);