using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMath;

namespace AstroServer
{
    // Define the service implementation class
    // Implementation class provide actual logic for the methods defined in the 'IAstroContract' Interface using formula from AstroMath.DLL
    [ServiceBehavior (InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        // Implementation of the formula under AstroMath.DLL 
        // No instances required as the formula under DLL is static class
        public double StarVelocity(double a, double b)
        {
            return AstronomicalFormula.StarVelocity(a, b);
        }

        public double StarDistance(double a)
        {
            return AstronomicalFormula.StarDistance(a);
        }

        public double TemperatureInKelvin(double a)
        {
            return AstronomicalFormula.TemperatureInKelvin(a);
        }

        public double EventHorizon(double a)
        {
            return AstronomicalFormula.EventHorizon(a);
        }
    }
}
