using System;
using Messages;
using NServiceBus;

namespace Logic
{
    public class EventHandler : IHandleMessages<EventHappened>
    {
        public void Handle(EventHappened message)
        {
            Console.WriteLine("Recieved Event");
        }
    }
}