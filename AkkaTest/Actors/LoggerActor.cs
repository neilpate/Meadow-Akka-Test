using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Event;
using AkkaTest.Messages;

namespace AkkaTest.Actors
{
    class LoggerActor : ReceiveActor
    {
        public LoggerActor()
        {
            Receive<LogMsg>(message => HandleLogMessage(message));
        }

        private void HandleLogMessage(LogMsg message)
        {
            Console.WriteLine($"{message.Body}");
        }

        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new LoggerActor());
        }

    }
}
