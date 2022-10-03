
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events
{
    internal class MessageSender
    {
        public void OnVideoEncoded(object obj , EventArgs e)
        {
            Console.WriteLine("Sending Message to user ............");
        }
    }
    internal class SendMail
    {
        public void OnVideoEncoded(object obj , EventArgs e)
        {
            Console.WriteLine("Sending mail to the user");
        }
    }
}
