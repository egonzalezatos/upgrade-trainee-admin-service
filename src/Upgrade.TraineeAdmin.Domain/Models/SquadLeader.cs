using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class SquadLeader : LogicEntity<int, int>
    {
        public UserProfile UserProfile { get; set; }
    }
}