namespace ReadApi.Models
{
    public class UserAnswer
    {
        public Guid UserAnswerId { get; set; }
        public Guid UserAttemptId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public Guid QuestionOptionId { get; set; }

        public UserAttempt UserAttempt { get; set; }
        public QuizQuestion QuizQuestion { get; set; }
        public QuestionOption QuestionOption { get; set; }
    }
}
