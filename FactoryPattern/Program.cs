namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle you want to drive have?");
            var userCar = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userCar);
            vehicle.Drive();


        }
    }
}
