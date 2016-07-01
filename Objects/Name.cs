using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class Name
  {
    private string _firstName;
    private string _lastName;
    private string _fullName;

    public Name(string first, string last)
    {
      _firstName = first;
      _lastName = last;
      _fullName = first + " " + last;
    }

    public string GetFullName()
    {
      return _fullName;
    }
  }
}
