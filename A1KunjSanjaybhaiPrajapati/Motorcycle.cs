using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A1KunjSanjaybhaiPrajapati
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(int id, string name, double rentalPrice, bool isReserved,string type, string category) : base(id,name,rentalPrice,isReserved,type,category) 
        {
           
        }

    }
}
