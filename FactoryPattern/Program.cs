namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = true;
            do
            {
                Console.Clear();
                input = true;
                Console.WriteLine("Please enter the amount of tires for the desired vehicle");

                 input = int.TryParse(Console.ReadLine(), out numOfWheels);
                if (numOfWheels !=2 && numOfWheels != 3 && numOfWheels != 4)
                {
                    input = false;
                    Console.WriteLine("User input not recognized");
                    Thread.Sleep(1000);
                }
            } while (input == false);
            Console.Clear();

           var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
        }
    }
}
