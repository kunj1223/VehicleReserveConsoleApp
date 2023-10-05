using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1KunjSanjaybhaiPrajapati
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public double RentalPrice { get; set; }
        public Boolean IsReserved { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }

        public Vehicle(int id, string name, double rentalPrice,bool isReserved,string type, string category)
        {
            Id = id;
            Name = name;
            RentalPrice = rentalPrice;
            IsReserved = isReserved;
            Type = type;
            Category = category;
        }

        public override string ToString()
        { 
            if(IsReserved)
                return $"{Id,-5}{Name,-50}{RentalPrice,10:c}{Category,10}  {Type,13}  {"NO",5}";
            else
                return $"{Id,-5}{Name,-50}{RentalPrice,10:c}{Category,10}  {Type,13}  {"Yes",5}";
        } 
    }
}
