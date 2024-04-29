using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class Quiz
    {
        public Guid QuizId { get; set; }
        public int CourseId { get; set; }
        public string NameOfQuiz { get; set; }
        public int Duration { get; set; }
        public int PassMark { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<QuizQuestion> QuizQuestions { get; set; }
        public ICollection<UserAttempt> UserAttempts { get; set; }
    }
}
