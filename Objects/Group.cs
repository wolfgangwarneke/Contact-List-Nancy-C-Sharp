using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Group
  {
    private static List<string> _definedGroups = new List<string>(new string[] { "family", "friends", "work" });

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
  }
}
