using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class FeedbackResponse
    {
        public Guid FeedbackResponseId { get; set; }
        public Guid FeedbackQuestionId { get; set; }
        public int UserId { get; set; }
        public string Response { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        public FeedbackQuestion FeedbackQuestion { get; set; }
    }
}
