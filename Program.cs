using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_089;

namespace ServerChatApp_089_Prasetyo_Nur_Hidayat
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(ServiceCallback));
                hostObj.Open();

                Console.WriteLine("Server On, Ready to Use");
                Console.ReadLine();

                hostObj.Close();
            }
            catch (Exception e)
            {
                hostObj = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
