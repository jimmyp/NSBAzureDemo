using System;
using NServiceBus.Saga;

namespace Logic
{
    public class ThreeEventsData : ISagaEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string Originator { get; set; }
        public virtual string OriginalMessageId { get; set; }

        public virtual int NumEvents { get; set; }
    }
}