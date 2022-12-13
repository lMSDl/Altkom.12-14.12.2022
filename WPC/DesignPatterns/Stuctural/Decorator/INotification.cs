using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Decorator
{
    internal interface INotification
    {
        void Send(string message);
    }
}
