using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Bridge.II
{
    internal class SmsSender : IMessageSenderImplementation
    {
        public const int MaxLengh = 16;

        public void SendMessage(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLengh))
                                           .Select(x => message.Substring(x * MaxLengh, Math.Min(MaxLengh, message.Length - x * MaxLengh))))
            {
                Console.WriteLine($"SMS: {item}");
            }


        }
    }
}
