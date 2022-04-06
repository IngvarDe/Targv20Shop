using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Targv20Shop.Core.Domain;
using Targv20Shop.Data;

namespace Targv20Shop.SpaceshipTest.Mock
{
    public class SpaceshipMock
    {
        //not in use
        public void Seed(Targv20ShopDbContext context)
        {
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();


            string guid = "a1925975-d8fc-4f55-b614-d9b5aa7b4ebe";

            //var sessions = new List<SpaceshipTestPropertys>();
            context.Spaceship.AddRange(new Spaceship()
            {
                Id = Guid.Parse(guid),
                Name = "Space",
                Type = "Cargo",
                Mass = 123,
                Prize = 123,
                Crew = 123,
                ConstructedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            });

            context.SaveChanges();
            //return sessions;
        }
    }
}
