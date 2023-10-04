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
		private double RentalPrice { get; set; }
        private Boolean IsReserved { get; set; }

        public Vehicle(int id, string name, double rentalPrice,bool isReserved)
        {
            Id = id;
            Name = name;
            RentalPrice = rentalPrice;
            IsReserved = isReserved;
        }

        public override string ToString()
        { 
            return $"{Id,-5} {Name,10} {RentalPrice,10:c} {IsReserved,7}";
        }
    }
}
