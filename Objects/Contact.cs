using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Contact
  {
    private static List<Contact> _allContacts = new List<Contact> {};
    private Dictionary<string, string> _contactData = new Dictionary<string, string>();

    private Name _name;
    //phone number
    //email
    //address
    private string _company;
    //group
    //birthday

    public Contact (Dictionary<string, string> fieldList)
    {
      _name = new Name(fieldList["firstName"], fieldList["lastName"]);
      _contactData = fieldList;
      _allContacts.Add(this);
    }

    public void AddContact(Contact contactToAdd)
    {
      _allContacts.Add(contactToAdd);
    }

    public static List<Contact> GetAllContacts()
    {
      return _allContacts;
    }

    public string GetField(string key)
    {
      return _contactData[key];
    }

  }
}
