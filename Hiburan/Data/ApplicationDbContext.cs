using Hiburan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hiburan.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Quiz> Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Quizes
            #region Quiz

            builder.Entity<Quiz>().HasData(new Quiz() { Id = 1 });

            builder.Entity<Question>().HasData(
                new { Id = 1, QuizId = 1 }
            );

            #endregion

        }
    }
}
