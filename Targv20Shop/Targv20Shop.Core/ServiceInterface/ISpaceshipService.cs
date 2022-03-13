using System;
using System.Threading.Tasks;
using Targv20Shop.Core.Domain;
using Targv20Shop.Core.Dtos;

namespace Targv20Shop.Core.ServiceInterface
{
    public interface ISpaceshipService : IApplicationService
    {
        Task<Spaceship> GetAsync(Guid id);
        Task<Spaceship> Add(SpaceshipDto dto);
        Task<Spaceship> Update(SpaceshipDto dto);
        Task<Spaceship> Delete(Guid id);
    }
}
