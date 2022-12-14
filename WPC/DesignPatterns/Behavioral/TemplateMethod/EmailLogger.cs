using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<Email, IDisposable>
    {
        protected override void Save(Email item, IDisposable? service)
        {
            Console.WriteLine("Sending Email with Log Message : " + item.Content);
        }

        protected override Email CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new Email { Subject = "Logger", Content = message };
        }

        protected override IDisposable GetService()
        {
            return null;
        }
    }
}
