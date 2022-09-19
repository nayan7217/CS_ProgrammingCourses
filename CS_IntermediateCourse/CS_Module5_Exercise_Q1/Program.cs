// Method Overriding
using CS_Module5_Exercise_Q1;
TimeSpan time = new TimeSpan(0, 2, 30);
string choice = "";

int option;

do
{
    Console.WriteLine("Enter the Connection string ");
    string Connection = Console.ReadLine();
    try
    {
        SqlConnection sqlConnection = new SqlConnection(Connection, time);

        OracleConnection oracleConnection = new OracleConnection(Connection, time);

        Console.WriteLine("1. SQL Connection");
        Console.WriteLine("2. Oracle Connection");
        int op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 1:
                string ch1 = "";
                bool IsConnectedSQl = false;
                do
                {
                    Console.WriteLine("                          1. Opening Method");
                    Console.WriteLine("                          2. Closing Method");
                    option = Convert.ToInt32(Console.ReadLine());
                    
                    switch (option)
                    {
                        case 1:
                            if (IsConnectedSQl == false)
                            {
                                sqlConnection.OpeningMethod();
                                IsConnectedSQl = true;
                            }
                            else
                            {
                                Console.WriteLine("Connection is Already Opened");
                            }
                            break;
                        case 2:
                            if (IsConnectedSQl == true)
                            {
                                sqlConnection.CloseingMethod();
                                IsConnectedSQl = false;

                            }
                            else
                            {
                                Console.WriteLine("Opps Connection is not Opened ! Not able to close the connection");
                            }
                            break;
                    }
                   
                    Console.WriteLine("Enter exit to stop");
                    ch1 = Console.ReadLine();
                } while (ch1 != "exit");
                break;
            case 2:
                string ch2 = "";
                bool IsConnectedOracle = false;
                do
                {
                    Console.WriteLine("                          1. Opening Method");
                    Console.WriteLine("                          2. Closing Method");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            if (IsConnectedOracle == false)
                            {
                                sqlConnection.OpeningMethod();
                                IsConnectedOracle = true;
                            }
                            else
                            {
                                Console.WriteLine("Connection is Already Opened");
                            }
                            break;
                        case 2:
                            if (IsConnectedOracle == true)
                            {
                                sqlConnection.CloseingMethod();
                                IsConnectedOracle = false;

                            }
                            else
                            {
                                Console.WriteLine("Opps Connection is not Opened ! Not able to close the connection");
                            }
                            break;
                    }
                    break;

                } while(ch2 != "exit");
                break;
        }
       

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    

    

} while(choice != "exit");

