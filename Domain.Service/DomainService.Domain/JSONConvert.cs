using DomainService.Domain.Models;
using Newtonsoft.Json;

namespace DomainService.Domain
{

  public class JSONConvert
  {

    public string Convert(StarModel star){

      return JsonConvert.SerializeObject(star);

    }

    public string Convert(ConstellationModel constellation){

      return JsonConvert.SerializeObject(constellation);

    }

    public string Convert(PlanetModel planet){

      return JsonConvert.SerializeObject(planet);

    }

    public string Convert(SolarSystemModel solarSystem){

      return JsonConvert.SerializeObject(solarSystem);

    }

  }

}