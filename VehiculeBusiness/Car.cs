using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleBusiness
{
    public class Car:IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Je roule");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
