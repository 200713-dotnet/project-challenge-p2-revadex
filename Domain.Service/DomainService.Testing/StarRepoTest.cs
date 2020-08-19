using System;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Xunit;

namespace DomainService.Testing
{
    public class StarRepoTest
    {
        [Fact]
        public void GetStar()
        {

          Console.WriteLine("Get Star Test:");

          DomainServiceRepository repo = new DomainServiceRepository();

          Console.WriteLine(repo.GetStarByName("Dubhe").Name + "\n");

        }

        [Fact]
        public void GetConstellation()
        {

          Console.WriteLine("Get Constellation Test:");

          DomainServiceRepository repo = new DomainServiceRepository();
          ConstellationModel bigDipper = repo.GetConstellationByName("Big Dipper");
          
          Console.WriteLine("Big Dipper Stars: ");

          foreach (StarModel star in bigDipper.Stars){
            Console.WriteLine(star.Name);
          }

          Console.WriteLine("");

        }
    }
}
