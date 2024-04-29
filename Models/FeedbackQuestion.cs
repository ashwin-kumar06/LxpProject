using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class FeedbackQuestion
    {
        public Guid FeedbackQuestionId { get; set; }
        public int CourseId { get; set; }
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

        public ICollection<FeedbackResponse> FeedbackResponses { get; set; }
    }
}
