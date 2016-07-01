using Nancy;
using ContactList.Objects;
using PageDisplay;
using System.Collections.Generic;

namespace ContactList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        Display newDisplay = new Display();
        return View["index.cshtml", newDisplay];
      };
      Get["/viewContacts"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        Display newDisplay = new Display();
        return View["index.cshtml", newDisplay];
      };
      Get["/goToForm"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        Display newDisplay = new Display();
        return View["addcontact.cshtml", newDisplay];
      };
      Post["/addContact"] = _ => {
        AddContactFormInput newInput = new AddContactFormInput(
          Request.Form["firstName"],
          Request.Form["lastName"],
          Request.Form["phoneNumber"],
          Request.Form["email"],
          Request.Form["address"],
          Request.Form["company"]
          );
        Contact newContact = new Contact(newInput.GetFormFields());
        List<Contact> allContacts = Contact.GetAllContacts();
        Display newDisplay = new Display();
        return View["contacts.cshtml", newDisplay];
      };
      Get["/clear"] = _ => {
        Contact.RemoveAllContacts();
        List<Contact> allContacts = Contact.GetAllContacts();
        Display newDisplay = new Display();
        return View["contacts.cshtml", newDisplay];
      };
    }
  }
}
