using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Binding
{
    internal class EmailNotification : Notification
    {

        public string Email { get; set; }

        public EmailNotification(string email, string message) : base(message) {  Email = email; }

        public override void Send()
        {
            Console.WriteLine($"Sending email notifcation from email {Email} with message {Message}");
        }

    }
}
