using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
	class PhoneBook
	{
        private List<Contact> _contacts {get;set;}

        public void AddContact (Contact contact)
        {
            _contacts.Add(contact);
        }
	}
}

