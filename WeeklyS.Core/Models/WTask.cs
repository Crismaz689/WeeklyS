using System;
using System.ComponentModel.DataAnnotations;

namespace WeeklyS.Core.Models
{
    public class WTask
    {
        public int WTaskId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsRepeatable { get; set; }

        [Required]
        public User User { get; set; }
    }
}
