using System;
using System.Threading;
using NServiceBus.Hosting.Azure;

namespace Worker
{
    public class WorkerRole : RoleEntryPoint
    {
        public override bool OnStart()
        {
            //Let diagnostics catch up
            Thread.Sleep(TimeSpan.FromSeconds(10));

            return base.OnStart();
        }

    }
}
