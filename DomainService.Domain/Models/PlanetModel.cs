using System;

namespace DomainService.Domain.Models
{

    public class PlanetModel : AModel
    {

      public double Magnitude {get;set;}

      public double Distance {get;set;}

      public double Radius {get;set;}

      public double Mass {get;set;}

      public double Volume {get;set;}

      public string Description {get;set;}

    }

}
