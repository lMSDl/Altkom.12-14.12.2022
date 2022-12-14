using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var user = new ChatUser("Paul");
            var bot1 = new ChatBot("Alexa");
            var bot2 = new ChatBot("Siri");

            var chat = new Chat();

            user.Mediator = chat;
            bot1.Mediator = chat;
            bot2.Mediator = chat;

            while (true)
            {
                var message = Console.ReadLine();
                var splittedMessage = message.Split(" $ ");
                if (splittedMessage.Length > 1)
                {
                    user.Mediator.Send(user.Nick, splittedMessage[0], splittedMessage[1]);
                }
                else
                {
                    user.Mediator.Send(user.Nick, message);
                }
            }
        }
    }
}
