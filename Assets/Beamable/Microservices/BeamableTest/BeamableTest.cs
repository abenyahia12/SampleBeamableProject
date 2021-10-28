using Beamable.Server;

namespace Beamable.Server.BeamableTest
{
   [Microservice("BeamableTest")]
   public class BeamableTest : Microservice
   {
      [ClientCallable]
      public void ServerCall()
      {
         // This code executes on the server.
      }
   }
}