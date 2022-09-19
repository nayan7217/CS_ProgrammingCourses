using CS_Module2_Exercise_Q1;

Stopwatch stopwatch = new Stopwatch();
bool isStarted = false;

while(true)
{
    Console.WriteLine("1. Start ");
    Console.WriteLine("2. End ");
    int op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 1:
            if (isStarted == false)
            {
                stopwatch.Start();
                isStarted = true;
            }
            else
            {
                Console.WriteLine("Opps! StopWatch Already Started");
            }
            break;
        case 2:
            if(isStarted != false)
            {
                stopwatch.End();
                isStarted = false;
                break;
            }
            else
            {
                Console.WriteLine("Opps ! The Stop Watch is not Started yet");
            }
            break;


    }
}