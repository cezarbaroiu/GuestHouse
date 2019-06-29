using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace GuestHouse.Web.OwinHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var owinHostAddress = ConfigurationManager.AppSettings["OwinHostUrl"];

                using (var owin = WebApp.Start<Startup>(owinHostAddress))
                {
                    Console.WriteLine("OwinWebServer started on {0}", owinHostAddress);
                    Console.WriteLine("Press Enter key to exit...");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
