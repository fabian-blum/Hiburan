using Hiburan.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hiburan.Data
{
    public class SeedData
    {
        public static void SeedFortgeschrittenenQuiz(ApplicationDbContext context)
        {
            if (!context.Quizzes.Any(x => x.Title == "Fortgeschrittenen Quiz"))
            {
                var quiz = new Quiz
                {
                    Title = "Fortgeschrittenen Quiz",
                    Questions = new List<Question>()
                };


                context.Quizzes.AddAsync(quiz);
                context.SaveChanges();

                #region Question

                var question = new Question
                {
                    Text = "Was bedeutet die Abkürzung CSS?",
                    AnswerText =
                        "Die Abkürzung CSS steht für Cascading Style Sheets und ist eine Auszeichnungssprache. CSS wird eingesetzt, wenn Webseiten gestaltet werden sollen.",
                    ImagePath =
                        "https://smartybro.com/wp-content/uploads/2018/03/Aprende-a-crear-p%C3%A1ginas-web-con-HTML5-y-CSS3.jpg",
                    Position = 1,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "Cool Style Sheets"},
                        new Option {OptionText = "Computer Style Sheets"},
                        new Option {OptionText = "Cascading Style Sheets"},
                        new Option {OptionText = "Carton Style Sheets"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == "Cascading Style Sheets");
                context.SaveChanges();

                #endregion

                #region Question

                question = new Question
                {
                    Text = "Wie greift man in der CSS auf eine in der HTML angelegte Klasse zu?",
                    AnswerText =
                        "Ein Klassenselektor spricht Elemente an, die einer bestimmten Klasse zugehörend sind. Welche Elemente das sind," +
                        " hängt von der verwendeten Auszeichnungssprache ab. In HTML-Dokumenten werden Klassen über das class-Attribut vergeben." +
                        " Es wird ein Klassenselektor gebildet, wenn vor dem Klassennamen ein Punkt notiert wird.",
                    ImagePath =
                        "https://smartybro.com/wp-content/uploads/2018/03/Aprende-a-crear-p%C3%A1ginas-web-con-HTML5-y-CSS3.jpg",
                    Position = 2,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "#class"},
                        new Option {OptionText = ".class"},
                        new Option {OptionText = "//class"},
                        new Option {OptionText = "!class"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == ".class");
                context.SaveChanges();

                #endregion

            }
        }

    }
}
