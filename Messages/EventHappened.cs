using System;
using NServiceBus;

namespace Messages
{
    public interface EventHappened : IEvent
    {
        Guid Id { get; set; }
    }
}