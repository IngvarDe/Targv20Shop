using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Targv20Shop.Core.Domain;
using Targv20Shop.Core.Dtos;
using Targv20Shop.Core.ServiceInterface;
using Targv20Shop.Data;


namespace Targv20Shop.ApplicationServices.Services
{
    public class SpaceshipServices : ISpaceshipService
    {
        private readonly Targv20ShopDbContext _context;


        public SpaceshipServices
            (
                Targv20ShopDbContext context
            )
        {
            _context = context;
        }

        public async Task<Spaceship> Edit(Guid id)
        {
            var result = await _context.Spaceship
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Spaceship> Add (SpaceshipDto dto)
        {
            Spaceship spaceship = new Spaceship();

            spaceship.Id = Guid.NewGuid();
            spaceship.Name = dto.Name;
            spaceship.Mass = dto.Mass;
            spaceship.Prize = dto.Prize;
            spaceship.Type = dto.Type;
            spaceship.Crew = dto.Crew;
            spaceship.ConstructedAt = dto.ConstructedAt;
            spaceship.CreatedAt = DateTime.Now;
            spaceship.ModifiedAt = DateTime.Now;

            await _context.Spaceship.AddAsync(spaceship);
            await _context.SaveChangesAsync();

            return spaceship;
        }

        public async Task<Spaceship> Update(SpaceshipDto dto)
        {
            Spaceship spaceship = new Spaceship();

            spaceship.Id = dto.Id;
            spaceship.Name = dto.Name;
            spaceship.Mass = dto.Mass;
            spaceship.Prize = dto.Prize;
            spaceship.Type = dto.Type;
            spaceship.Crew = dto.Crew;
            spaceship.ConstructedAt = dto.ConstructedAt;
            spaceship.CreatedAt = dto.CreatedAt;
            spaceship.ModifiedAt = dto.ModifiedAt;

            _context.Spaceship.Update(spaceship);
            await _context.SaveChangesAsync();

            return spaceship;
        }

        public async Task<Spaceship> Delete(Guid id)
        {
            var spaceship = await _context.Spaceship
                .FirstOrDefaultAsync(x => x.Id == id);

            _context.Spaceship.Remove(spaceship);
            await _context.SaveChangesAsync();

            return spaceship;
        }
    }
}
