using System.Collections;
using System.Collections.Generic;
using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class JobProfile : Entity<int>
    {
        public Position Position { get; set; }

        public Technology Technology { get; set; }

        public Level Level { get; set; }
        
        public ICollection<Trainee> Trainees { get; set; } 
    }
}