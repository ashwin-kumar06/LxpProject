using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class UserAnswer
    {
        public Guid UserAnswerId { get; set; }
        public Guid UserAttemptId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public Guid QuestionOptionId { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public UserAttempt UserAttempt { get; set; }
        public QuizQuestion QuizQuestion { get; set; }
        public QuestionOption QuestionOption { get; set; }
    }
}
