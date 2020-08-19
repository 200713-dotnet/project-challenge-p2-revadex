using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
  public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;
    private List<ConstellationButtonModel> _northStarButtons;
    private List<ConstellationButtonModel> _southStarButtons;

    public HomeController(ILogger<HomeController> logger) {
      _logger = logger;
    }

    public IActionResult Index() {
      _northStarButtons = new List<ConstellationButtonModel>{
        new ConstellationButtonModel {name = "Test", constellation = "Test", top = 50, left = 50}
      };
      _southStarButtons = new List<ConstellationButtonModel>{
        new ConstellationButtonModel {name = "Test", constellation = "Test", top = 50, left = 50}
      };
      HomeViewModel model = new HomeViewModel();
      model.north = _northStarButtons;
      model.south = _southStarButtons;
      return View(model);
    }

    public IActionResult Privacy() {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // public List<ConstellationButtonModel> GetNorthStars() {
    //   List<ConstellationButtonModel> ret = new List<ConstellationButtonModel>();
    //   ret.AddRange(_northStarButtons);
    //   return ret;
    // }

    // public List<ConstellationButtonModel> GetSouthStars() {
    //   List<ConstellationButtonModel> ret = new List<ConstellationButtonModel>();
    //   ret.AddRange(_southStarButtons);
    //   return ret;
    // }
  }
}
