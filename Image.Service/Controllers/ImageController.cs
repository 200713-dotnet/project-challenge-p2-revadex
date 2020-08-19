using Microsoft.AspNetCore.Controllers;

namespace Pikture.Service.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ImageController : ControllerBase
  {

    [HttpGet]
    public IActionResult Get()
    {
      return Ok();
      // return all images from db
    }

    [HttpGet]
    public IActionResult Get(/* based off name */)
    {
      //query db for image with matching name
    }
  }
}