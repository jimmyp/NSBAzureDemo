using System;
using NServiceBus;

namespace Messages
{
    public class SomeCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}