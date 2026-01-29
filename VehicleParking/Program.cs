using System.Data;
using System.Diagnostics;
using VehicleParking.Parking;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal startingPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the starting price:");
startingPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the price per hour:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking parkingValue = new Parking(startingPrice, pricePerHour);

string opcao = string.Empty;
bool Menu = true;

while (Menu)
{
    Console.WriteLine("Choose an option:\n" +
                      "1 - Add vehicle\n" +
                      "2 - Remove vehicle\n" +
                      "3 - List vehicles\n" +
                      "4 - Exit");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            parkingValue.addVehicle();
            break;
        case "2":
            parkingValue.removeVehicle();
            break;
        case "3":
            parkingValue.listVehicles();
            break;
        case "4":
            Menu = false;
            break;
        default:
            Console.WriteLine("Invalid option! Please choose a valid option.");
            break;
    }
}

