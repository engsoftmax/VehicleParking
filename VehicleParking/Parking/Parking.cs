
using System.Security.Cryptography.X509Certificates;

namespace VehicleParking.Parking
{
    public class Parking
    {
        private decimal startingPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicle = new List<string>();
        private List<string> plate = new List<string>();

        public Parking(decimal startingPrice, decimal pricePerHour)
        {
            this.startingPrice = startingPrice;
            this.pricePerHour = pricePerHour;
        }
        public void addVehicle()
        {
            Console.WriteLine("Please enter the vehicle model and license plate number.");
            string vehicle = Console.ReadLine();
            string plate = Console.ReadLine();

        }
        public void removeVehicle()
        {
            Console.WriteLine("Please enter the license plate number of the vehicle to remove:");
            string plate = Console.ReadLine();
            if (plate.Contains(plate))
            {
                Console.WriteLine("Please enter the number of hours the vehicle was parked:");
                int hoursParked = int.Parse(Console.ReadLine());
                decimal totalPrice = startingPrice + (pricePerHour * hoursParked);
                vehicle.Remove(plate);
                Console.WriteLine($"The vehicle with license plate {plate} has been removed. Total price: {totalPrice:C}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please check the license plate number.");
            }

        }
        public void listVehicles()
        {
            if (vehicle.Count > 0)
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (var v in vehicle)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles parked.");
            }
        }




    }
}



