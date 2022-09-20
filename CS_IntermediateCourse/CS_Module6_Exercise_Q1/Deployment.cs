using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module6_Exercise_Q1
{
    public class Deployment : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Project Deployed");
            return;
        }
    }
}
