using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module5_Exercise_Q2
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public TimeSpan Timeout { get; set; }

        public bool isConnected;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if(connectionString == "")
            {
                throw new ArgumentNullException("The given String Value is Null Enter the Correct value of the string");
            }
            Timeout = timeout;
        }
        // Class must be abstract for using the abstract Method;
        public abstract void OpeningMethod();

        public abstract void CloseingMethod();

    }
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString,timeout)
        {

        }
        public override void OpeningMethod()
        {
            Console.WriteLine("Opening Method SQL is Called");
            isConnected = true;
            return;
        }
        public override void CloseingMethod()
        {
            Console.WriteLine("Closing Methd is SQL called");
            isConnected=false;
            return;
        }
    }
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {

        }
        public override void OpeningMethod()
        {
            Console.WriteLine("Opening Method Oracle is Called");
            isConnected=true;
            return;
        }
        public override void CloseingMethod()
        {
            Console.WriteLine("Closing Method Oracle is called");
            isConnected = false;
            return;
        }
    }

}
