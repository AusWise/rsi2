using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1Contract;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfService1Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:1014/Cw2/");

            ServiceHost mojHost = new ServiceHost(typeof(Service1), baseAdress);

            try
            {
                mojHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

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
