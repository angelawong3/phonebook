using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
	class PhoneBook
	{
        private List<Contact> _contacts {get;set;}

        private void DisplayContactDetails (Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        public void AddContact (Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found:(");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContact()
        {
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayMatchingContact(String searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach (var contact in matchingContacts)
            {
                DisplayContactDetails(contact);
            }
        }
	}
}

