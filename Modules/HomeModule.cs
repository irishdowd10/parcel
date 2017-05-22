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
        myParcelVariables.SetWeight(Request.Query["eight"]);
        myParcelVariables.SetWidth(Request.Query["width"]);
        myParcelVariables.SetHeight(Request.Query["height"]);
        myParcelVariables.SetLength(Request.Query["Length"]);
        return View["info.cshtml", myWParcelVariables];
      };
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
