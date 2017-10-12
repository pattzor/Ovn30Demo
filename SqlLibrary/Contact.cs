using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string ssn, int id)
        {
            Firstname = firstName;
            Lastname = lastName;
            SSN = ssn;
            ID = id;
        }

        public Contact(string firstName, string lastName, string ssn)
        {
            Firstname = firstName;
            Lastname = lastName;
            SSN = ssn;
        }

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SSN { get; set; }


    }
}
