namespace ReadApi.Models
{
    public class QuestionOption
    {
        public Guid QuestionOptionId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }

        public QuizQuestion QuizQuestion { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
