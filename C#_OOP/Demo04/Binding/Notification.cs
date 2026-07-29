using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Binding
{
    internal class Notification
    {
        public string Message { get; set; }

        public Notification (string message)
        {
            Message = message;
        } 

        public virtual void Send()
        {
            Console.WriteLine($"Sending notification with message {Message}");
        }

    }
}
