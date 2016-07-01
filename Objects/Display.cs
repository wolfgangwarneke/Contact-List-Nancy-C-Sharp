using System.Collections.Generic;
using System.Threading;
using ContactList.Objects;

namespace PageDisplay
{
  public class Display
  {
        private string _headerHTML;
        private string _contactsHTML;
        private string _groupOptionsHTML;

        public Display()
        {
          _headerHTML = Header.GetHTML();
          _contactsHTML = Contact.GetHTML();
          _groupOptionsHTML = Group.GetHTML();
        }

        public string GetHeaderHTML()
        {
          return _headerHTML;
        }

        public string GetContactsHTML()
        {
          return _contactsHTML;
        }

        public string GetGroupOptionsHTML()
        {
          return _groupOptionsHTML;
        }


  }
}
