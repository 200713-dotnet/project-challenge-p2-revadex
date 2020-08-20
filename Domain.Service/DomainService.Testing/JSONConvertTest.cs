using System;
using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Xunit;

namespace DomainService.Testing
{
    public class JSONConvertTest
    {
        [Fact]
        public void StarConvert()
        {

          Console.WriteLine("JSON Star Convert Test");

          DomainServiceRepository repo = new DomainServiceRepository();

          JSONConvert jconv = new JSONConvert();

          StarModel star = repo.GetStarByName("Dubhe");

          Console.WriteLine(jconv.Convert(star));

        }

        [Fact]
        public void ConstellationConvert(){

          Console.WriteLine("Constellation Convert Test:");

          DomainServiceRepository repo = new DomainServiceRepository();
          ConstellationModel bigDipper = repo.GetConstellationByName("Big Dipper");

          JSONConvert jconv = new JSONConvert();

          Console.WriteLine(jconv.Convert(bigDipper));

        }

    }
}
