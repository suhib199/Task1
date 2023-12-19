using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
