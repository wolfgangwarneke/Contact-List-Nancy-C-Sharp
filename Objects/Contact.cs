using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Contact
  {
    private static List<Contact> _allContacts = new List<Contact> {};
    private Dictionary<string, string> _contactData = new Dictionary<string, string>();

    //name
    //phone number
    //email
    //address
    //company
    //group
    //birthday

    public Contact (Dictionary<string, string> fieldList)
    {
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

    public static void RemoveAllContacts()
    {
      _allContacts.Clear();
    }

    public static string GetHTML()
    {
      string HTML = "<div>";
      foreach (Contact contact in _allContacts) {
        HTML += "<div class='contact'>";
        HTML += "<h1>" + contact.GetField("firstName") + " " + contact.GetField("lastName") + "</h1>";
        HTML += "<h2>" + contact.GetField("phoneNumber") + "</h2>";
        HTML += "<h2>" + contact.GetField("email") + "</h2>";
        HTML += "<h2>" + contact.GetField("address") + "</h2>";
        HTML += "<h2>" + contact.GetField("company") + "</h2>";
        HTML += "</div>";
      }
      HTML += "</div>";
      return HTML;
    }
  }
}
