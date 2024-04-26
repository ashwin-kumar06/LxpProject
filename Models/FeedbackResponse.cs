namespace ReadApi.Models
{
    public class FeedbackResponse
    {
        public Guid FeedbackResponseId { get; set; }
        public Guid FeedbackQuestionId { get; set; }
        public int UserId { get; set; }
        public string Response { get; set; }
        public FeedbackQuestion FeedbackQuestion { get; set; }
    }
}
