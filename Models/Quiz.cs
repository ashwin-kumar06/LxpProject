using System.Collections.ObjectModel;

namespace ReadApi.Models
{
    public class Quiz
    {
        public Guid QuizId { get; set; }
        public int CourseId { get; set; }
        public string NameOfQuiz { get; set; }
        public int Duration { get; set; }
        public int PassMark { get; set; }

        public ICollection<QuizQuestion> QuizQuestions { get; set; }
        public ICollection<UserAttempt> UserAttempts { get; set; }
    }
}
