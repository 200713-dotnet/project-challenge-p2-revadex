using Microsoft.AspNetCore.Mvc;

namespace StarDex.Client.Controllers {
    public class PlanetController : Controller {
      [HttpGet]
      public string Get(string name) {
        return name;
      }
    }
}