using Nancy;
using CsharpMadlib.Objects;

namespace parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
       Get["/info"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables();
        myParcelVariables.SetName(Request.Query["name"]);
        myParcelVariables.SetPlace(Request.Query["place"]);
        myParcelVariables.SetAction(Request.Query["action"]);
        myParcelVariables.SetAdjective(Request.Query["adjective"]);
        myParcelVariables.SetAge(Request.Query["age"]);
        return View["info.cshtml", myWParcelVariables];
      };
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
