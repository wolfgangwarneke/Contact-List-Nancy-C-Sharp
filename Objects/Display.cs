using System.Collections.Generic;
using System.Threading;
using ContactList.Objects;

namespace PageDisplay
{
  public class Display
  {
        private string _headerHTML;
        private string _contactsHTML;

        public Display()
        {
          _headerHTML = Header.GetHTML();
          _contactsHTML = Contact.GetHTML();
        }

        public string GetHeaderHTML()
        {
          return _headerHTML;
        }

        public string GetContactsHTML()
        {
          return _contactsHTML;
        }




  }
}
