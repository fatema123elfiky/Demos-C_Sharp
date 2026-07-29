using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Binding
{
    internal class SMSNotification : Notification
    {
        public string Number { get; set; }

        public SMSNotification(string message ,string number) :base(message){ Number = number; }

        public override void Send()
        {
            Console.WriteLine($"Send sms notifcation from number {Number} with message {Message}");
        }

    }
}
