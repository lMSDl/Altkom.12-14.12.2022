namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        private IMediator mediator;
        public string Nick { get; }

        public IMediator Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}