using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Repositories
{
    public interface ITraineeRepository : IRepository<Trainee, int>
    {
        Task<List<Trainee>> FindByUserIds(params int[] userId);
    }
}