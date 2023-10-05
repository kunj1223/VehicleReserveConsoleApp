using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1KunjSanjaybhaiPrajapati
{
    public class Functions
    {
        public static void ShowMenu()
        {
            Console.WriteLine("                    Please choose from Following options");
            Console.WriteLine("                    1 - View All Vehicles");
            Console.WriteLine("                    2 - View Available Vehicles");
            Console.WriteLine("                    3 - View Reserved Vehicles");
            Console.WriteLine("                    4 - Reserve A Vehicles");
            Console.WriteLine("                    5 - Cancel reservation");
            Console.WriteLine("                    6 - Exit");
            Console.Write("Enter Your Choice :  ");
        }

        public static List<Vehicle> LoadVehicles(List<Vehicle> vehicles)
        {
            vehicles.Add(new Car(1, "Honda Civic", 69.9, false, "Standard", "Sedan"));
            vehicles.Add(new Car(2, "Toyota Corolla", 69.9, false, "Standard", "Sedan"));
            vehicles.Add(new Car(3, "Ford Explorer", 99.9, true, "Standard", "SUV"));
            vehicles.Add(new Car(4, "Lamborghini Aventador", 189.9, false, "Exotic", "Sports"));
            vehicles.Add(new Car(5, "Ferrari 488 GTB", 179.9, false, "Exotic", "Sports"));
            vehicles.Add(new Car(6, "McLaren Pl", 199.9, true, "Exotic", "Sports"));
            vehicles.Add(new Motorcycle(7, "Suzuki Boulevard M109R", 49.9, false, "Bike", "Cruiser"));
            vehicles.Add(new Motorcycle(8, "Honda CRF125", 69.9, false, "Bike", "Dirt"));
            vehicles.Add(new Motorcycle(9, "Ducati Monster", 39.9, false, "Bike", "Sports"));
            vehicles.Add(new Motorcycle(10, "Can-Am Spyder", 59.9, true, "Trike",
              "Cruiser"));
            vehicles.Add(new Motorcycle(11, "Polaris Slingshot", 69.9, false, "Trike", "Cruiser"));

            return vehicles;
        }

        public static void ShowVehicles(List<Vehicle> vehicles) 
        {
            Console.WriteLine($"{"ID",-5}{"Name",-50}{"Rental Price",10}{"Category",10}  {"Type",13}  {"Available",10}");
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
            Console.WriteLine("\n");
        }

        public static void ShowAvailableVehicles(List<Vehicle> vehicles)
        {

            Console.WriteLine($"{"ID",-5}{"Name",-50}{"Rental Price",10}{"Category",10}  {"Type",13}  {"Available",10}");
            var availableVehicles = from vehicle in vehicles
                                    where !vehicle.IsReserved
                                    select vehicle;

            if (availableVehicles.Count() > 0)
            {
                foreach (Vehicle v in availableVehicles)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
        }

        public static void ShowReservedVehicles(List<Vehicle> vehicles)
        {
            Console.WriteLine($"{"ID",-5}{"Name",-50}{"Rental Price",10}{"Category",10}  {"Type",13}  {"Available",10}");
            var reservedVehicles = from vehicle in vehicles
                                    where vehicle.IsReserved
                                    select vehicle;
            if(reservedVehicles.Count() > 0 )
            {
                foreach (Vehicle v in reservedVehicles)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            else
            {
                Console.WriteLine("\n");
            }          
        }
        public static void MakeReservation(List<Vehicle> vehicles)
        {
            Console.WriteLine("All Available Vehicles");
            Console.WriteLine($"{"ID",-5}{"Name",-50}{"Rental Price",10}{"Category",10}  {"Type",13}  {"Available",10}");
            var availableVehicles = from vehicle in vehicles
                                    where !vehicle.IsReserved
                                    select vehicle;

            if (availableVehicles.Count() > 0)
            {
                foreach (Vehicle v in availableVehicles)
                {
                    Console.WriteLine(v.ToString());
                }
                Console.WriteLine("\n");
                Console.Write("Please Make a Choice : ");
                int num;
                int.TryParse(Console.ReadLine(), out num);

                var chosenVehicle = from vehicle in vehicles where vehicle.Id == num select vehicle;
                if(chosenVehicle.Count() > 0 ) 
                {
                    foreach (Vehicle v in chosenVehicle)
                    {
                        v.IsReserved = true;
                    }
                    Console.WriteLine("Vehicle reservation Is Successful");
                    ShowVehicles(vehicles);
                }
                else
                {
                    Console.WriteLine("Please Make a Valid selection.");
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
        }

        public static void CancelReservation(List<Vehicle> vehicles)
        {
            Console.WriteLine("All Reserved Vehicles");
            Console.WriteLine($"{"ID",-5}{"Name",-50}{"Rental Price",10}{"Category",10}  {"Type",13}  {"Available",10}");
            var reservedVehicles = from vehicle in vehicles
                                    where vehicle.IsReserved
                                    select vehicle;

            if (reservedVehicles.Count() > 0)
            {
                foreach (Vehicle v in reservedVehicles)
                {
                    Console.WriteLine(v.ToString());
                }
                Console.WriteLine("\n");
                Console.Write("Please Make a Choice : ");
                int num;
                int.TryParse(Console.ReadLine(), out num);

                var chosenVehicle = from vehicle in vehicles where vehicle.Id == num select vehicle;
                if (chosenVehicle.Count() > 0)
                {
                    foreach (Vehicle v in chosenVehicle)
                    {
                        v.IsReserved = false;
                    }
                    Console.WriteLine("Vehicle reservation Is cancelled.");
                    ShowVehicles(vehicles);
                }
                else
                {
                    Console.WriteLine("Please Make a Valid selection.");
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
        }
    }
}
