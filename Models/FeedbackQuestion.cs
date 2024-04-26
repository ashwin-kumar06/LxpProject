namespace ReadApi.Models
{
    public class FeedbackQuestion
    {
        public Guid FeedbackQuestionId { get; set; }
        public int CourseId { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }

        public ICollection<FeedbackResponse> FeedbackResponses { get; set; }
    }
}
