namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");
            string userInput = Console.ReadLine();

            IVehicle instance = VehicleFactory.GetVehicle(userInput);
    
        }
    }
}
