using System;
using NServiceBus;

namespace Logic
{
    public class AuthHandler : IHandleMessages<IEvent>
    {
        private readonly IBus _bus;

        public AuthHandler(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }

        public void Handle(IEvent message)
        {
            string username;
            _bus.CurrentMessageContext.Headers.TryGetValue("username", out username);
            if(username != null && username != "jim")
                _bus.DoNotContinueDispatchingCurrentMessageToHandlers();
        }
    }
}