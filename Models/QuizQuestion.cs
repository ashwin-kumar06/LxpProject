using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class QuizQuestion
    {
        public Guid QuizQuestionId { get; set; }
        public Guid QuizId { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public Quiz Quiz { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
