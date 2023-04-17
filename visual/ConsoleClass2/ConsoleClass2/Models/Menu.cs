using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClass2.Models
{
    public class Menu
    {
        public string Name { get; set; }
        public decimal Price;
        public int Portion; 
        public string PhotoUrl = "img/default.jpg"; //o demekdirki img ozumuz daxil etmedikde dault olaraq bir img goturur
        public DateTime CreatedDate = DateTime.Now; //yazsaq tarixi default olaraq hemin gun goturur 
        public string Description;


        public double GetTax()
        {
            return (double)Price * 0.14; //casting demekdi, tipler arasi keciddi
        }

    }
}







//Class lar PaskalCase
//field camelCase
