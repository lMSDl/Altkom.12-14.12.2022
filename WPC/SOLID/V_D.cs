using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID
{
    interface IMessage
    {
        void SendMessage();
    }

    class SMS : IMessage 
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMessage()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail : IMessage 
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }

        public void SendMessage()
        {
            SendMail();
        }
    }

    class Messenger
    {

        public IEnumerable<IMessage> Messages { get; set; }
        /*public SMS SMS { get; set; }
        public MMS MMS { get; set; }
        public Mail Mail { get; set; }*/

        public Messenger(IEnumerable<IMessage> messages) {
            Messages = messages;
        }

        public void SendMessages(IEnumerable<IMessage> messages)
        {

            foreach (var message in messages)
            {
                message.SendMessage();
            }
        }
        public void SendMessages()
        {
            SendMessages(Messages);

            /*SMS?.SendSMS();
            MMS?.SendMMS();
            Mail?.SendMail();*/
        }
    }
}
