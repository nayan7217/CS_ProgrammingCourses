using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Module5_Exercise_Q2;

namespace CS_Module5_Exercise_Q2
{
    public abstract class DbCommand
    {
        public bool isConnected;

        public string sqlCommand;


        public DbCommand(SqlConnection obj, string sqlCommand)
        {
            isConnected = obj.isConnected;
            this.sqlCommand = sqlCommand;
        }

        public abstract void Execute();
    }
    public class Sql : DbCommand
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
    public class oracle : DbCommand
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
