
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Indexers
{
    public class Employee
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }

        }
      

    }
}
