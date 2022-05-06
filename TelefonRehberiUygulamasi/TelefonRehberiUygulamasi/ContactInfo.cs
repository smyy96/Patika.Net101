using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelefonRehberiUygulamasi
{
    public class ContactInfo // propertyler
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }


        public ContactInfo(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}
