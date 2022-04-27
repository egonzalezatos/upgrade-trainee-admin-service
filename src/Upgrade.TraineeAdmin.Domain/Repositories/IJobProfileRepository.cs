using System.Threading.Tasks;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Repositories
{
    public interface IJobProfileRepository : IRepository<JobProfile, int>
    {
        public Task<JobProfile> FindByPositionIdAndLevelIdAndTechnologyId(int positionId, int levelId, int technologyId);
    }
}