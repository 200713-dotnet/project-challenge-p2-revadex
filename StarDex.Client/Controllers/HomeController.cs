using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
  public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;
    // private List<ConstellationButtonModel> northStarButtons;
    // private List<ConstellationButtonModel> southStarButtons;
    private List<ConstellationButtonModel> starButtons;

    public HomeController(ILogger<HomeController> logger) {
      _logger = logger;
    }

    public IActionResult Index() {
      starButtons = StarButtons();
      HomeViewModel model = new HomeViewModel();
      model.stars = starButtons;
      return View(model);
    }

    List<ConstellationButtonModel> StarButtons() {
      return new List<ConstellationButtonModel>{
        new ConstellationButtonModel {name = "Ursa Minor", top = -2070, left = 65},
        new ConstellationButtonModel {name = "Ursa Major", top = -1270, left = 85}
      };
    }

    public IActionResult Privacy() {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
