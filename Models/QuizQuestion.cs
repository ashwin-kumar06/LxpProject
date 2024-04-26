using System.Collections.ObjectModel;

namespace ReadApi.Models
{
    public class QuizQuestion
    {
        public Guid QuizQuestionId { get; set; }
        public Guid QuizId { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }

        public Quiz Quiz { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
