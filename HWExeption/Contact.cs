using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExeption
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
                throw new InvalidContactException("Имя или номер телефона не могут быть пустыми.");

            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
