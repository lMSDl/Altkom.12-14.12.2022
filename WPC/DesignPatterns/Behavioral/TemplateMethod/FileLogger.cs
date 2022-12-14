using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override string PrepareMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return base.PrepareMessage(message);
        }


        protected override void Save(string item, FileService? service)
        {
            service.Write(item);
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override FileService GetService()
        {
            return new FileService();
        }
    }
}
