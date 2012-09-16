using System;
using Messages;
using NServiceBus.Saga;

namespace Logic
{
    public class ThreeEvents : Saga<ThreeEventsData>,
        IAmStartedByMessages<EventHappened>
    {
        public override void ConfigureHowToFindSaga()
        {
            ConfigureMapping<EventHappened>(m => m.Id, s => s.Id);
        }
        public void Handle(EventHappened message)
        {
            Data.Id = message.Id;
            Data.NumEvents++;

            if(Data.NumEvents > 2)
                Console.WriteLine("3 event received.");
        }
    }
}