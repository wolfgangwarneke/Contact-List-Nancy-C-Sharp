using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Group
  {
    private static List<string> _definedGroups = new List<string>(new string[] { "family", "friends", "work" });
    private static string _groupSortHTML;


    public static string GetHTML()
    {
      string HTML = "";
      foreach (var groupName in _definedGroups)
      {
        HTML += "<option value='" + groupName + "'>" + groupName + "</option>";
      }
      return HTML;
    }
    public static void AddDefinedGroup(string groupName)
    {
      _definedGroups.Add(groupName);
    }
    public static void IfNotContainsThenAdd(string groupName)
    {
      if (!_definedGroups.Contains(groupName))
      {
        _definedGroups.Add(groupName);
      }
    }

    public static void SetGroupSortHTML(string groupName)
    {
      List<Contact> ContactsToSort = Contact.GetAllContacts();
      string HTML = "<div>";
      foreach (Contact contact in ContactsToSort) {
        if (contact.GetField("group") == groupName)
        {
        HTML += "<div class='contact'>";
        HTML += "<h1>" + contact.GetField("firstName") + " " + contact.GetField("lastName") + "</h1>";
        HTML += "<h4>" + contact.GetField("group") + "</h4>";
        HTML += "<h2>" + contact.GetField("phoneNumber") + "</h2>";
        HTML += "<h2>" + contact.GetField("email") + "</h2>";
        HTML += "<h2>" + contact.GetField("address") + "</h2>";
        HTML += "<h2>" + contact.GetField("company") + "</h2>";
        HTML += "</div>";
        }
      }
      HTML += "</div>";
      _groupSortHTML = HTML;
    }

    public static string GetGroupSortHTML()
    {
      return _groupSortHTML;
    }
  }
}
