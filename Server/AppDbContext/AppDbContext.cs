using Microsoft.EntityFrameworkCore;
using System;
using Tool.Server.Models;


    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<QuizModel> Quizs { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<QuestionType> QuestionTypes { get; set; }
    public DbSet<QuizQuestion> QuizQuestions { get; set; }
    public DbSet<QuizReport> QuizReports { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Score> Scores { get; set; }
    public DbSet<UserAnswer> UserAnswers { get; set; }
    public DbSet<UserAnswerMapping> UserAnswerMappings { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Relation between Role and User
        modelBuilder.Entity<Role>()
            .HasOne(r => r.User)
            .WithOne(u => u.Role)
            .HasForeignKey<User>(u => u.RoleCode)
            .OnDelete(DeleteBehavior.Cascade);


        //Relation between Quiz and QuizQuestion 
        modelBuilder.Entity<QuizQuestion>()
            .HasOne(q => q.Quiz)
            .WithMany(qu => qu.QuizQuestions)
            .HasForeignKey(q => q.QuizId)
            .OnDelete(DeleteBehavior.Restrict);

        //Relation between QuizQuestion and QuestionOption
        modelBuilder.Entity<QuizQuestion>()
           .HasMany(q => q.QuestionOptions)
           .WithOne(o => o.QuizQuestion)
           .HasForeignKey(o => o.QuestionId)
           .OnDelete(DeleteBehavior.Restrict);

        //Relation between quiz and QuestionOption
        modelBuilder.Entity<QuestionOption>()
           .HasOne(q => q.Quiz)
           .WithMany(qo => qo.QuestionOptions)
           .HasForeignKey(qo => qo.QuizId)
           .OnDelete(DeleteBehavior.Restrict);

        //Relation between QuestionType and QuizQuestion
        modelBuilder.Entity<QuestionType>()
           .HasOne(q => q.QuizQuestion)
           .WithOne(q => q.QuestionType)
           .HasForeignKey<QuizQuestion>(q => q.QuestionTypeId)
           .OnDelete(DeleteBehavior.Restrict);

        //Relation between Quiz and QuizReport
        modelBuilder.Entity<QuizReport>()
           .HasOne(q => q.Quiz)
           .WithMany(qr => qr.QuizReports)
           .HasForeignKey(qr => qr.QuizId)
           .OnDelete(DeleteBehavior.Restrict);

        //Relation between Quiz and Score
        modelBuilder.Entity<Score>()
          .HasOne(s => s.Quiz)
          .WithMany(q => q.Scores)
          .HasForeignKey(s => s.QuizId)
          .OnDelete(DeleteBehavior.Restrict);

        //Relation between QuizQuestion and UserAnswer
        modelBuilder.Entity<UserAnswer>()
           .HasOne(u => u.QuizQuestion)
           .WithMany(q => q.UserAnswers)
           .HasForeignKey(u => u.QuestionId)
           .OnDelete(DeleteBehavior.Restrict);

        //Realation between User and score
        modelBuilder.Entity<User>()
           .HasMany(u => u.Scores)
           .WithOne(s => s.User)
           .HasForeignKey(s => s.UserId)
           .OnDelete(DeleteBehavior.Restrict);

    }


}
