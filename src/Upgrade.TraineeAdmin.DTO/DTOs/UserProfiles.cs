using System.Collections.Generic;

namespace Upgrade.TraineeAdmin.DTO.DTOs
{
    public class UserProfiles
    {
        public int UserId { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}