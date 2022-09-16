using CS_Module2_Exercise_Q2;

Post post1 = new Post("I love my India", "Gratitude towards Country", DateTime.Now);
int ch;
do
{
    ch = 1;
    Console.WriteLine("1. Up vote");
    Console.WriteLine("2. Dawn vote");
    Console.WriteLine("3. Print the total Votes");
    int op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1: post1.UpVote();
            Console.WriteLine("Successfully Voted to the Post");
            break;
        case 2:post1.DawnVote();
            Console.WriteLine("Successfully Voted to the Post");
            break;
        case 3:post1.PrintVote();
            break;
    }
    Console.WriteLine("Enter 1 to continue or anything to exit");
    ch = Convert.ToInt32(Console.ReadLine());


    
}while (ch == 1);



