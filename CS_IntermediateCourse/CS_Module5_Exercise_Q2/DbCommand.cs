using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Module5_Exercise_Q2;

namespace CS_Module5_Exercise_Q2
{
    public class DbCommand
    {
        public bool isConnected;


        public DbCommand(SqlConnection obj)
        {
            isConnected = obj.isConnected;
        }

        public void Execute(SqlCommand cmd)
        {

        }
    }
}
