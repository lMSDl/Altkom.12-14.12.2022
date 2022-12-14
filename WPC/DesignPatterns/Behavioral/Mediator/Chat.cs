using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    internal class Chat : IMediator
    {
        private readonly ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember chatMember)
        {
            _chatMembers.Add(chatMember);
        }

        public void Quit(ChatMember chatMember)
        {
            _chatMembers.Remove(chatMember);
        }

        public void Send(string from, string message)
        {
            var sender = _chatMembers.Single(x => x.Nick == from);

            var query = _chatMembers.Where(x => x.Nick != from);
            if (sender is ChatBot)
                query = query.Where(x => !(x is ChatBot));

            foreach (var member in query)
            {
                member.Receive(from, message, false);
            }
        }

        public void Send(string from, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }
    }
}
