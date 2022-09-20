using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Module6_Exercise_Q1;

namespace CS_Module6_Exercise_Q1
{
    public class WorkflowEngine
    { 
        public void Run(List<IActivity> list)
        {
            foreach(var activity in list)
            {
                activity.Execute();
            }
        }
    }
}
