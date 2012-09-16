using System;
using Messages;
using NServiceBus;

namespace Logic
{
    class CommandHandler : IHandleMessages<SomeCommand>
    {
        private readonly IBus _bus;

        public CommandHandler(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }

        public void Handle(SomeCommand message)
        {
            Console.WriteLine("Recieved Some Command");
            _bus.SetHeader("username", "jim");
            _bus.Publish<EventHappened>(m => m.Id = message.Id);
        }
    }
}
