using System;
using Targv20Shop.ApplicationServices.Services;
using Targv20Shop.Core.Dtos;
using Targv20Shop.Core.ServiceInterface;
using Targv20Shop.Models.Spaceship;
using Xunit;

namespace Spaceship.Test
{
    public class SpaceshipCreate
    {
        private readonly ISpaceshipService _spaceship;

        public SpaceshipCreate
            (
                ISpaceshipService spaceship
            )
        {
            spaceship = _spaceship;
        }


        [Fact]
        public void When_CreateNewSpaceship_ThenItWillAddNewData()
        {
            // Arrange

            var spaceship = new SpaceshipDto
            {
                Name = "Superman",
                Type = "Corvette",
                Mass = 123,
                Prize = 123,
                ConstructedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                Crew = 123
            };

            var result = _spaceship.Add(spaceship);

            //Assert.Empty(result);
        }
    }
}
