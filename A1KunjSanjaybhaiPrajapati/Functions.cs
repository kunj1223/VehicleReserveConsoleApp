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
        }

        public static List<Vehicle> LoadVehicles(List<Vehicle> vehicles)
        {
            vehicles.Add(new Car(1, "Corolla", 32.25, false, "sedan", "none"));
            vehicles.Add(new Motorcycle(2, "none", 25.25, true, "Hi", "Kunj"));
            return vehicles;
        }
    }
}
