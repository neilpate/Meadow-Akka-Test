using System;
using Meadow;
using Meadow.Devices;
using Akka.Actor;
using AkkaTest.Actors;
using AkkaTest.Messages;

namespace AkkaTest
{
    public class MeadowApp : App<F7Micro, MeadowApp>
    {
        public MeadowApp()
        {
            Initialize();
          
        }

        void Initialize()
        {
            var actorSystem = ActorSystem.Create("Main");

            var loggerActor = actorSystem.ActorOf(LoggerActor.Props(), "Logger");

            var logHi = new LogMsg("Hi");

            loggerActor.Tell(logHi);

            Console.ReadLine();
        
        }

      
    }
}
