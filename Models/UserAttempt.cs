using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class UserAttempt
    {
        public Guid UserAttemptId { get; set; }
        public int UserId { get; set; }
        public Guid QuizId { get; set; }
        public int AttemptCount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float Score { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public Quiz Quiz { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
