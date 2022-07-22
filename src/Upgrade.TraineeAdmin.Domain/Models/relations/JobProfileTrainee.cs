using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models.relations
{
    public class JobProfileTrainee : Entity<int> //Pivot
    {
        public Trainee Trainee { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}