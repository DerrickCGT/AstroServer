using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroServer
{
    // Define the service contract interface
    // It connects the implementation class methods to the client application.
    [ServiceContract]
    internal interface IAstroContract
    {
        // Declare the Method contract that
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);

        [OperationContract]
        double StarDistance(double arsecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celcius);

        [OperationContract]
        double EventHorizon(double blackholeMass);

    }
}
