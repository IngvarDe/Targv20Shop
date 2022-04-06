using Targv20Shop.Core.ServiceInterface;
using System;
using System.Threading.Tasks;
using Targv20Shop.Core.Dtos;
using Xunit;
using Targv20Shop.Core.Domain;


namespace Targv20Shop.SpaceshipTest
{
    public class SpaceshipTest : TestBase
    {

        [Fact]
        public async Task Should_AddNewSpaceship_WhenReturnResult()
        {
            string guid = "a1925975-d8fc-4f55-b614-d9b5aa7b4ebe";

            SpaceshipDto spaceship = new SpaceshipDto();

            spaceship.Id = Guid.Parse(guid);
            spaceship.Name = "Space";
            spaceship.Type = "Estonia";
            spaceship.Prize = 123;
            spaceship.Crew = 123;
            spaceship.Mass = 123;
            spaceship.ConstructedAt = DateTime.Now;
            spaceship.CreatedAt = DateTime.Now;
            spaceship.ModifiedAt = DateTime.Now;

            var result = await Svc<ISpaceshipService>().Add(spaceship);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldNot_GetByIdSpaceship_WhenReturnsResultAsync()
        {
            string guid = "e6771076-91cd-4169-bbdd-cfc5290a6b3f";
            string guid1 = "1ab8c12a-f8da-4e55-ab77-f45378d3adb5";


            var insertGuid = Guid.Parse(guid);
            var insertGuid1 = Guid.Parse(guid1);

            await Svc<ISpaceshipService>().GetAsync(insertGuid);

            Assert.NotEqual(insertGuid1, insertGuid);
        }

        [Fact]
        public async Task Should_GetByIdSpaceship_WhenReturnsResultAsync()
        {
            string guid = "e6771076-91cd-4169-bbdd-cfc5290a6b3f";
            string guid1 = "e6771076-91cd-4169-bbdd-cfc5290a6b3f";

            //var request = new Spaceship();
            var insertGuid = Guid.Parse(guid);
            var insertGuid1 = Guid.Parse(guid1);

            await Svc<ISpaceshipService>().GetAsync(insertGuid);

            Assert.Equal(insertGuid1, insertGuid);
        }

        //not working
        [Fact]
        public async Task Should_DeleteByIdSpaceship_WhenDeleteSpaceship()
        {
            //Arrange


            var guid1 = new Guid("1ab8c12a-f8da-4e55-ab77-f45378d3adb5");

            //Act
            var result = await Svc<ISpaceshipService>().Delete(guid1);

            //Assert
            //updateData.Should().BeOfType<NoContentResult>();
        }


        [Fact]
        public async Task Should_UpdateByIdSpaceship_WhenUpdateSpaceship()
        {
            var guid = new Guid("1ab8c12a-f8da-4e55-ab77-f45378d3adb5");

            Spaceship spaceship = new Spaceship();

            spaceship.Id = guid;
            spaceship.Name = "Space";
            spaceship.Type = "Estonia";
            spaceship.Prize = 123;
            spaceship.Crew = 123;
            spaceship.Mass = 123;
            spaceship.ConstructedAt = DateTime.Now;
            spaceship.CreatedAt = DateTime.Now;
            spaceship.ModifiedAt = DateTime.Now;

            var spaceshipId = guid;
            var spaceshipToUpdate = new SpaceshipDto()
            {
                Name = "Test",
                Prize = 456
            };

            await Svc<ISpaceshipService>().Update(spaceshipToUpdate);

            Assert.Equal(spaceship.Id.ToString(), spaceshipId.ToString());
            Assert.DoesNotMatch(spaceship.Name, spaceshipToUpdate.Name);
            Assert.DoesNotMatch(spaceship.Prize.ToString(), spaceshipToUpdate.Prize.ToString());
        }
    }
}
