using System;
using System.Collections.Generic;
using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class Trainee : LogicEntity<int, int>
    {
        public UserProfile UserProfile { get; set; }
        public List<JobProfile> JobProfiles { get; set; } //null
        public int? CurrentCareerId { get; set; }
        public byte[] OnBoardingDate { get; set; } //UNIX TIMESTAMP 

        
    }
}