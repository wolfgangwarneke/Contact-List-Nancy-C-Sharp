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
        string FirstName = contact.GetField("firstName");
        string LastName = contact.GetField("lastName");
        string Group = contact.GetField("group");
        string Phone = contact.GetField("phoneNumber");
        string Email = contact.GetField("email");
        string Address = contact.GetField("address");
        string Company = contact.GetField("company");

        /*
          Very curious problem
          where I have to define variables
          up above to make the conditional work
          Is it scoping?  Can I not call that method in a conditional?
        */

        if (Group == groupName)
        {
        HTML += "<div class='contact'>";
        HTML += "<h1>" + FirstName + " " + LastName + "</h1>";
        HTML += "<h4>" + Group + "</h4>";
        HTML += "<h2>" + Phone + "</h2>";
        HTML += "<h2>" + Email + "</h2>";
        HTML += "<h2>" + Address + "</h2>";
        HTML += "<h2>" + Company + "</h2>";
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
