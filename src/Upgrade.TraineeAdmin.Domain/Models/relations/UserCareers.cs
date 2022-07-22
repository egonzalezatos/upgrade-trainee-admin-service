using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models.relations
{
    public class UserCareers : Entity<int>
    {
        public int CareerId { get; set; }
        public int UserId { get; set; }
    }
}