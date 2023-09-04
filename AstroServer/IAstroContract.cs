using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

// Name: Derrick Choong
// ID: 30066568
// Date: 04/09/2023

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
        double StarDistance(double arcSecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celcius);

        [OperationContract]
        double EventHorizon(double blackholeMass);

    }
}
