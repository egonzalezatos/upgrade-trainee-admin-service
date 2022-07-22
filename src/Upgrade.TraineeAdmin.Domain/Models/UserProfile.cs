using System.ComponentModel.DataAnnotations;
using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Models
{
    public class UserProfile : LogicEntity<int, int>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string DasId { get; set; }
    }
}