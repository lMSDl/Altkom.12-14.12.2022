using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WPC.DesignPatterns.Creational.Singleton;

namespace WPC.DesignPatterns.Stuctural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {

            var abstraction = new MessageAbstraction();

            abstraction.MessageSender = new SmsSender();
            abstraction.Send(Console.ReadLine());

            abstraction.MessageSender = new EmailSender();
            abstraction.Send(Console.ReadLine());
        }
    }
}
