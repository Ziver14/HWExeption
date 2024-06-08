using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExeption
{
    public class ContactsManager
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(string name, string phoneNumber)
        {
            try
            {
                var contact = new Contact(name, phoneNumber);
                contacts.Add(contact);
            }
            catch (InvalidContactException ex)
            {
                throw new InvalidContactException(ex.Message);
            }
        }

        public List<Contact> FindContactByName(string name)
        {
            return contacts.Where(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
