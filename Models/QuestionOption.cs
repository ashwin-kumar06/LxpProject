using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class QuestionOption
    {
        public Guid QuestionOptionId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public QuizQuestion QuizQuestion { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
