using Nancy;
using ContactList.Objects;
using System.Collections.Generic;

namespace ContactList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["index.cshtml", allContacts];
      };
      Get["/viewContacts"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["index.cshtml", allContacts];
      };
      Get["/goToForm"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["addcontact.cshtml", allContacts];
      };
      Post["/addContact"] = _ => {
        AddContactFormInput newInput = new AddContactFormInput(
          Request.Form["firstName"],
          Request.Form["lastName"],
          Request.Form["phoneNumber"],
          Request.Form["email"],
          Request.Form["address"]
          );
        Contact newContact = new Contact(newInput.GetFormFields());
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["contacts.cshtml", allContacts];
      };
    }
  }
}
