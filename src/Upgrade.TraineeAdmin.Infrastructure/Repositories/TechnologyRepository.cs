using Sdk.Infrastructure.Repositories;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;

namespace Upgrade.TraineeAdmin.Infrastructure.Repositories
{
    public class TechnologyRepository : Repository<Technology, int>, ITechnologyRepository
    {
        public TechnologyRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}