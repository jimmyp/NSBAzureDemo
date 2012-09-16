using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Messages;
using NServiceBus;

namespace Website.Controllers
{
    public class SendCommandController : Controller
    {
        
        private readonly IBus _bus;

        public SendCommandController(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SendCommand()
        {
            _bus.Send(new SomeCommand() { Id = new Guid("5DF5B0BE-07B9-44DB-80F6-783FD6315CE9") });

            return View("Index");
        }

    }
}
