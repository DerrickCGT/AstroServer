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
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use "using" to ensure proper disposal of the serviceHost and prevent resource leaks
            using (ServiceHost serviceHost = new ServiceHost(typeof(AstroServer)))
            {
                // Define the address for the service using named pipes.
                string address = "net.pipe://localhost/astromath";

                // Create a binding for the service using named pipes with no security.
                NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

                // Add a service endpoint to the service host, specifying the contract and binding.
                serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);

                // Open the service host to start listening for incoming requests.
                serviceHost.Open();

                // Display a message indicating that the service host is running and keep the console opened.
                Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
                Console.ReadLine();

                // Close the service host to stop listening for incoming requests.
                serviceHost.Close();
            }
        }
    }
}
