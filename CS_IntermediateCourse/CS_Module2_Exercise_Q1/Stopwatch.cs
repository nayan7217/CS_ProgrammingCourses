using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module2_Exercise_Q1
{
    public class Stopwatch
    {
        DateTime timeStart;

        DateTime timeEnd;

        public void Start()
        {
            this.timeStart = DateTime.Now;
            
        }
        public void End()
        {
            this.timeEnd = DateTime.Now;
            string str = $"Time Span : {timeEnd.Hour - timeStart.Hour}:{timeEnd.Second - timeEnd.Second}";
            Console.WriteLine(str);
            return;
        }
    
    }
}
