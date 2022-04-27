using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class Technology : LogicEntity<int, int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}