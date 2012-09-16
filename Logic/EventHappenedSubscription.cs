using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages;
using NServiceBus;

namespace Logic
{
    class EventHappenedSubscription : IWantToRunAtStartup
    {
        private readonly IBus _bus;

        public EventHappenedSubscription(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }

        public void Run()
        {
            _bus.Subscribe<EventHappened>();
        }

        public void Stop()
        {
        }
    }
}
