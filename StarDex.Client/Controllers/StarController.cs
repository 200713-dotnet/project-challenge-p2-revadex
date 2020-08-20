using Microsoft.AspNetCore.Mvc;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
    public class StarController : Controller {
      [HttpGet]
      public IActionResult Get(string name) {
        // TODO: Replace with database calls
        StarViewModel model = new StarViewModel{name = name};
        return View("Star", model);
      }
    }
}