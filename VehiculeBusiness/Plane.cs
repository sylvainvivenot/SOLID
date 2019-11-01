using System;

namespace VehicleBusiness
{
    public class Plane:IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Je roule");
        }
    }
}
