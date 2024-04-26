using Microsoft.EntityFrameworkCore;
using ReadApi.Models;
namespace ReadApi.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserAttempt> UserAttempts { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<FeedbackQuestion> FeedbackQuestions { get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizQuestion>()
                .HasOne(qq => qq.Quiz)
                .WithMany(q => q.QuizQuestions)
                .HasForeignKey(qq => qq.QuizId);

            modelBuilder.Entity<QuestionOption>()
                .HasOne(qo => qo.QuizQuestion)
                .WithMany(qq => qq.QuestionOptions)
                .HasForeignKey(qo => qo.QuizQuestionId);

            modelBuilder.Entity<UserAttempt>()
                .HasOne(ua => ua.Quiz)
                .WithMany(q => q.UserAttempts)
                .HasForeignKey(ua => ua.QuizId);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.UserAttempt)
                .WithMany(ua => ua.UserAnswers)
                .HasForeignKey(ua => ua.UserAttemptId);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.QuizQuestion)
                .WithMany(qq => qq.UserAnswers)
                .HasForeignKey(ua => ua.QuizQuestionId);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.QuestionOption)
                .WithMany(qo => qo.UserAnswers)
                .HasForeignKey(ua => ua.QuestionOptionId);

            modelBuilder.Entity<FeedbackResponse>()
                .HasOne(fr => fr.FeedbackQuestion)
                .WithMany(fq => fq.FeedbackResponses)
                .HasForeignKey(fr => fr.FeedbackQuestionId);
        }
    }
}
