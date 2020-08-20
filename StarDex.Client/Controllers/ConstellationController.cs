using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
  public class ConstellationController : Controller {
    [HttpGet]
    public IActionResult Get(string id) {
      ConstellationViewModel model = new ConstellationViewModel();
      model.name = id;
      // \/ \/ \/ REPLACE WITH DB GET CALLS
      if (id == "Ursa Minor") {
        model.description = "Ursa Minor (Latin: \"Lesser Bear\", contrasting with Ursa Major), also known as the Little Bear, is a constellation in the Northern Sky. Like the Great Bear, the tail of the Little Bear may also be seen as the handle of a ladle, hence the North American name, Little Dipper: seven stars with four in its bowl like its partner the Big Dipper. It was one of the 48 constellations listed by the 2nd-century astronomer Ptolemy, and remains one of the 88 modern constellations. Ursa Minor has traditionally been important for navigation, particularly by mariners, because of Polaris being the north pole star." +
        "Polaris, the brightest star in the constellation, is a yellow-white supergiant and the brightest Cepheid variable star in the night sky, ranging from an apparent magnitude of 1.97 to 2.00. Beta Ursae Minoris, also known as Kochab, is an aging star that has swollen and cooled to become an orange giant with an apparent magnitude of 2.08, only slightly fainter than Polaris. Kochab and magnitude 3 Gamma Ursae Minoris have been called the \"guardians of the pole star\".[3] Planets have been detected orbiting four of the stars, including Kochab. The constellation also contains an isolated neutron star—Calvera—and H1504+65, the hottest white dwarf yet discovered, with a surface temperature of 200,000 K.";
        model.stars = new List<StarViewModel>{
          new StarViewModel{name = "Polaris", distanceInLightYears = 443, temperatureInKelvin = 6900, solarMass = 5.4, description = "group of stars"},
          new StarViewModel{name = "Calvera", distanceInLightYears = 625, description = "a description - lots of info missing"},
          new StarViewModel{name = "β Ursae Minoris", distanceInLightYears = 130.9, temperatureInKelvin = 4030, solarMass = 2.2, description = "a description"}
        };
        model.imageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Ursa_Minor_IAU.svg/540px-Ursa_Minor_IAU.svg.png";
        return View("Constellation", model);
      } else if (id == "Ursa Major") {
        model.description = "Ursa Major (/ˈɜːrsə ˈmeɪdʒər/; also known as the Great Bear) is a constellation in the northern sky, whose associated mythology likely dates back into prehistory. Its Latin name means \"greater (or larger) she-bear\", referring to and contrasting it with nearby Ursa Minor, the lesser bear. In antiquity, it was one of the original 48 constellations listed by Ptolemy in the 2nd century AD. Today it is the third largest of the 88 modern constellations." +
        "Ursa Major is primarily known from the asterism of its main seven stars, which has been called the \"Big Dipper\", \"the Wagon\", \"Charles's Wain\", or \"the Plough\", among other names. In particular, the Big Dipper's stellar configuration mimics the shape of the \"Little Dipper\". Two of its stars, named Dubhe and Merak (α Ursae Majoris and β Ursae Majoris), can be used as the navigational pointer towards the place of the current northern pole star, Polaris in Ursa Minor." +
        "Ursa Major, along with asterisms that incorporate or comprise it, is significant to numerous world cultures, often as a symbol of the north. Its depiction on the flag of Alaska is a modern example of such symbolism." +
        "Ursa Major is visible throughout the year from most of the northern hemisphere, and appears circumpolar above the mid-northern latitudes. From southern temperate latitudes, the main asterism is invisible, but the southern parts of the constellation can still be viewed. ";
        model.stars = new List<StarViewModel>{
          new StarViewModel{name = "Groombridge 1830", distanceInLightYears = 29.93, temperatureInKelvin = 4759, solarMass = 0.661, description = "a description"},
          new StarViewModel{name = "Lalande 21185", distanceInLightYears = 8.31, temperatureInKelvin = 3828, solarMass = 0.46, description = "a description"},
          new StarViewModel{name = "ε UMa", distanceInLightYears = 81, temperatureInKelvin = 9020, solarMass = 2.91, description = "a description"}
        };
        model.imageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Ursa_Major_IAU.svg/600px-Ursa_Major_IAU.svg.png";
        return View("Constellation", model);
      }
      // /\ /\ /\ REPLACE WITH DB GET CALLS
      return Redirect("/");
    }
  }
}