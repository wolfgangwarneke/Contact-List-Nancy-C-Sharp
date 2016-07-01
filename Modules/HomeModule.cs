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
        List<Zombie> allZombies = Zombie.GetAll();
        return View["index.cshtml", allZombies];
      };

    }
  }
}
