using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HostSecurityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFSecuirtyTest.WCFAuthService)))
            {
                host.Open();

                Console.WriteLine("Host Started @-"+DateTime.Now.ToString());

                Console.WriteLine(host.BaseAddresses.ToString());
                Console.WriteLine(host.ToString());

                Console.ReadLine();

            }
        }
    }
}
