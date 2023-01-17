using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "2":
                case "two":
                    return new Motorcycle();
                case "4":
                case "four":
                    return new Car();
                case "18":
                case "eighteen":
                case "eight teen":
                case "eight-teen":
                    return new BigRig();
                default:
                    return new Car();

            }
        }
    }
}
