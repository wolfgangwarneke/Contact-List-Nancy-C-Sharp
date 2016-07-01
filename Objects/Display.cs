using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Display
  {
        private List<Contact> _contactsToDisplay = new List<Contact> {};
        private string _headerHTML;

        public Display(List<Contact> contacts)
        {
          _contactsToDisplay = contacts;
          _headerHTML = Header.GetHTML();
        }

        public string GetHeaderHTML()
        {
          return _headerHTML;
        }

  }
}
