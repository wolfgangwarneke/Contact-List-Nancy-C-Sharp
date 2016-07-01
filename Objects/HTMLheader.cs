using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public static class Header
  {
    private static string _HTML = "<header>"+
                    "<h1>Contact List</h1>"+
                    "<h3>Welcome, user</h3>"+
                  "</header>";

    public static string GetHTML()
    {
      return _HTML;
    }
  }
}
