using CS_Module5_Exercise_Q2;

TimeSpan time = new TimeSpan(0, 2, 30);

string Connection = Console.ReadLine();
SqlConnection sqlConnection = new SqlConnection(Connection, time);

OracleConnection oracleConnection = new OracleConnection(Connection, time);