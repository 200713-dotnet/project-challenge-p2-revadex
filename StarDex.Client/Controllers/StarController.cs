using Microsoft.AspNetCore.Mvc;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
    public class StarController : Controller {
      [HttpGet]
      public IActionResult Get(string name) {
        // TODO: Replace with database calls
        StarViewModel model = new StarViewModel{name = name};
        if (name == "Polaris") {
          return View("Star", new StarViewModel{name = "Polaris", distanceInLightYears = 443, temperatureInKelvin = 6900, solarMass = 5.4, description = "group of stars", imageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Polaris_alpha_ursae_minoris.jpg/800px-Polaris_alpha_ursae_minoris.jpg"});
        } else if (name == "Calvera") {
          return View("Star", new StarViewModel{name = "Calvera", distanceInLightYears = 625, description = "a description - lots of info missing"});
        } else if (name == "Mizar") {
          return View("Star", new StarViewModel{name = "Mizar", distanceInLightYears = 82.9, temperatureInKelvin = 9000, solarMass = 2.2381, description = "a description", imageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Mizar_and_Alcor.jpg/800px-Mizar_and_Alcor.jpg"});
        }
        return Redirect("/");
      }
    }
}