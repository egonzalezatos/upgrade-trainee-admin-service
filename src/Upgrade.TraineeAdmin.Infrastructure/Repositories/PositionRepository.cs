using Sdk.Infrastructure.Repositories;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;

namespace Upgrade.TraineeAdmin.Infrastructure.Repositories
{
    public class PositionRepository : Repository<Position, int>, IPositionRepository
    {
        public PositionRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}