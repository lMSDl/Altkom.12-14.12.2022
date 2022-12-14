using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value > 30)
            {

                Console.WriteLine("SubscriberA rozpoczął reagowanie");

                Thread.Sleep(2000);

                Console.WriteLine("SubscriberA zareagował");
            }
        }
    }
}
