using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ArithmeticServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ArithmeticService.ArithmeticService)))
            {
                host.Open();
                Console.WriteLine("Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
