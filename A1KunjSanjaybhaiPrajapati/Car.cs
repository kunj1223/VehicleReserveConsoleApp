using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A1KunjSanjaybhaiPrajapati
{
    public class Car : Vehicle
    {
        public string Type { get; set; }
        public string Category { get; set; }

        public Car(int id, string name, double rentalPrice, bool isReserved, string type, string category) : base(id, name, rentalPrice, isReserved)
        {
            Type = type;
            Category = category;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Type,5} {Category,10}";
        }

    }
}
