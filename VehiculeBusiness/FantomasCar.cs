using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleBusiness
{
    public class FantomasCar:IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Je vole");
        }

        public void Fly()
        {
            Console.WriteLine("Je roule");
        }
    }
}
