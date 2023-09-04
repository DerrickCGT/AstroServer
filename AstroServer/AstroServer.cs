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
        AstronomicalFormula formula = new AstronomicalFormula ();
        // Implementation of the formula under AstroMath.DLL 
        // If dll class is static, instance is not require to be created.
        AstronomicalFormula astroFormula = new AstronomicalFormula();

        public double StarVelocity(double a, double b)
        {
            return astroFormula.StarVelocity(a, b);
        }

        public double StarDistance(double a)
        {
            return astroFormula.StarDistance(a);
        }

        public double TemperatureInKelvin(double a)
        {
            return astroFormula.TemperatureInKelvin(a);
        }

        public double EventHorizon(double a)
        {
            return astroFormula.EventHorizon(a);
        }
    }
}
