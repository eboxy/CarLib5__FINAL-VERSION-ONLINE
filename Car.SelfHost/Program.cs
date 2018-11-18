using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarServices;

namespace Car.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (ServiceHost host = new ServiceHost(typeof(CarService)))
                {
                    host.Open();
                    Console.WriteLine("Self hosting!");
                    Console.WriteLine("Tryck vilken knapp som helst for avsluta");
                    Console.ReadKey();
                    host.Close();
                }
            }
            catch (Exception ex)
            {

                //Logga felet
                Debug.WriteLine(ex.Message);
            }

           
        }
    }
}
