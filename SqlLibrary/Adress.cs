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
        public string Type { get; set; }
        public string Street;
        public string City;

        public Adress(string type, string street, string city)
        {
            Type = type;
            Street = street;
            City = city;
        }
    }
}
