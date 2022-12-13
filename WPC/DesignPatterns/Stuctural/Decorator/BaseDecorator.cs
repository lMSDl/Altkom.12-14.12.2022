using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Decorator
{
    internal abstract class BaseDecorator : INotification
    {
        private readonly INotification notification;

        public BaseDecorator(INotification notification)
        {
            this.notification = notification;
        }

        public void Send(string message)
        {
            notification.Send(message);
            ExtraSend(message);
        }

        protected abstract void ExtraSend(string message);
    }
}
