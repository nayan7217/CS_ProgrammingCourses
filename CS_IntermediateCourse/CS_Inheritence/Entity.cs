
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string StaffName { get; set; }


        public void printName()
        {
            Console.WriteLine(StaffName);
            return;
        }

    }
    public class Doctor:Staff
    {
        public string Specialization { get; set; }

        public int FeesForOnePatient { get; set; }
    }
}
