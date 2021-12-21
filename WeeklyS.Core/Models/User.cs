using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeeklyS.Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordHashCode { get; set; }
        public ICollection<WTask> Tasks { get; set; }
    }
}
