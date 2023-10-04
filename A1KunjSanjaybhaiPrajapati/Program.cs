namespace A1KunjSanjaybhaiPrajapati;
using static A1KunjSanjaybhaiPrajapati.Functions;
 internal class Program
    {
        static void Main(string[] args)
        {
            //Showing Headers
            Console.WriteLine("\n");
            string name = "Assingment 1 - Kunj Sanjaybhai Prajapti";
            Console.WriteLine($"{name, 200}");
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //Printing Menu
            ShowMenu();

            //Creating List and Loading it 
            List<Vehicle> vehicles = new List<Vehicle>();
            LoadVehicles(vehicles);

            //Loading List
            foreach(Vehicle v in vehicles)
            {
               Console.WriteLine($"{v.ToString()}");
            }
               
        }
}