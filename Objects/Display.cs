using System.Collections.Generic;
using System.Threading;
using ContactList.Objects;

namespace PageDisplay
{
  public class Display
  {
        public static string STATE = "showAll";

        private string _headerHTML;
        private string _contactsHTML;
        private string _sortByGroupsHTML;
        private string _groupOptionsHTML;

        public Display()
        {
          _headerHTML = Header.GetHTML();
          _contactsHTML = Contact.GetHTML();
          _sortByGroupsHTML = Group.GetGroupSortHTML();
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

        public string GetSortByGroupsHTML()
        {
          return _sortByGroupsHTML;
        }

        public string GetGroupOptionsHTML()
        {
          return _groupOptionsHTML;
        }

        public static void setSTATE(string state)
        {
          STATE = state;
        }

        public string getSTATE()
        {
          return STATE;
        }
  }
}
