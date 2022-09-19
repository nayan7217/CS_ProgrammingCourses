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
            timeStart = DateTime.Now;
            Console.WriteLine($"Timer is Started at {timeStart}");
            return;
            
        }
        public void End()
        {
            timeEnd = DateTime.Now;
            Console.WriteLine($"Timestamp = {timeEnd - timeStart}");
            return;
        }
    
    }
}
