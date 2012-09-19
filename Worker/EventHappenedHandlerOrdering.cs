using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic;
using NServiceBus;

namespace Worker
{
    class EventHappenedHandlerOrdering : ISpecifyMessageHandlerOrdering
    {
        public void SpecifyOrder(Order order)
        {
            order.Specify(First<AuthHandler>.Then<Logic.EventHandler>());
        }
    }
}
