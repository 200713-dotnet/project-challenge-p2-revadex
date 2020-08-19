using DomainService.Domain.Models;

namespace DomainService.Domain.Factories
{

  public class StarFactory : IFactory
  {

    public AModel Create()
    {

      var s = new StarModel();

      return s;

    }

  }

}