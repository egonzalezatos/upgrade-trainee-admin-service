using System.ComponentModel.DataAnnotations;
using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class UserProfile : Entity<int>
    {
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public JobProfile JobProfile { get; set; }
    }
}