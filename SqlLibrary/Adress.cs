using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public class Adress
    {
        public int ID { get; set; }
        public string street;
        public string city;

        public Adress(string street, string city)
        {
            this.street = street;
            this.city = city;
        }
    }
}
