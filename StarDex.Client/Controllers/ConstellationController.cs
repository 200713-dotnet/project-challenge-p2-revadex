using Microsoft.AspNetCore.Mvc;

namespace StarDex.Client.Controllers {
  public class ConstellationController : Controller {
    public string Get(string id) {
      return id;
    }
  }
}