using System.Collections.Generic;
using System.Threading;

namespace ContactList.Objects
{
  public class AddContactFormInput
  {
    private Dictionary<string, string> _formFields = new Dictionary<string, string>();
    private string _fullName;

    public AddContactFormInput(string first, string last, string phone)
    {
      _formFields.Add("firstName", first);
      _formFields.Add("lastName", last);
      _formFields.Add("phoneNumber", phone);
    }

    public Dictionary<string, string> GetFormFields()
    {
      return _formFields;
    }

    // public void GetFullName()
    // {
    //   if ( (_formFields.TryGetValue("firstName", out test)) && (_formFields.TryGetValue("lastName", out test)) ) {
    //     _fullName = _formFields["firstName"] + " " + _formFields["lastName"];
    //   }
    // }
  }
}
