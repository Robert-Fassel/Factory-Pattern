using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle 
    {
        public Motorcycle() 
        {
        }
        public void Drive()
        {
            Console.WriteLine("The Motorcycle is revving up");
            Console.WriteLine("Vroooooom");
        }
        
    }
}
