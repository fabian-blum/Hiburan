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

            builder.Entity<Quiz>().HasData(new Quiz()
            {
                Id = 1,
                Title = "Fortgeschritten"
            });

            builder.Entity<Option>().HasData(new
            {
                Id = 1,
                OptionText = "Cool Style Sheets",
                QuestionId = 1
            });

            builder.Entity<Question>().HasData(
                new
                {
                    Id = 1,
                    QuizId = 1,
                    Position = 1,
                    Text = "Was bedeutet die Abkürzung CSS?",
                    CorrectOptionId = 1,
                    ImagePath = "https://smartybro.com/wp-content/uploads/2018/03/Aprende-a-crear-p%C3%A1ginas-web-con-HTML5-y-CSS3.jpg"
                }
            );


            #endregion

        }
    }
}
