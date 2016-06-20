using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService2Host;
using WcfService2Contract;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfService2Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:1014/Cw_2/");

            ServiceHost mojHost = new ServiceHost(typeof(Service2), baseAdress);

            try
            {
                mojHost.AddServiceEndpoint(typeof(IService2), new WSHttpBinding(), "Service2");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);

                mojHost.Open();
                Console.WriteLine("Serwis jest uruchomiony.");
                Console.WriteLine("Nacisnij <ENTER> aby zakonczyc. ");
                Console.WriteLine();
                Console.ReadLine();

                mojHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost.Abort();
            }
        }
    }
}
