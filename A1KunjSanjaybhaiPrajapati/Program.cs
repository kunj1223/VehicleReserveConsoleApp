namespace A1KunjSanjaybhaiPrajapati;

using System.ComponentModel;
using static A1KunjSanjaybhaiPrajapati.Functions;
internal class Program
{
    static void Main(string[] args)
    {
        //Showing Headers
        Console.WriteLine("\n");
        string name = "Assingment 1 - Kunj Sanjaybhai Prajapti";
        Console.WriteLine($"{name,200}");
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

        //Creating List and Loading it 
        List<Vehicle> vehicles = new List<Vehicle>();
        LoadVehicles(vehicles);

        // setting boolean to false
        bool exit = true;

        //While Loop
        while (exit)
        {
            //Displaying the Menu
            ShowMenu();

            int num;

            if (int.TryParse(Console.ReadLine(), out num))
            {
                switch (num)
                {

                    case 1:
                        ShowVehicles(vehicles);
                        break;
                    case 2:
                        ShowAvailableVehicles(vehicles);
                        break;
                    case 3:
                        ShowReservedVehicles(vehicles);
                        break;
                    case 4:
                        MakeReservation(vehicles);
                        break;
                    case 5:
                        CancelReservation(vehicles);
                        break;
                    case 6:
                        exit = false;
                        break;  
                }
            }
        }
    }
}