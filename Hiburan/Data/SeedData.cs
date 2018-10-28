using Hiburan.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hiburan.Data
{
    public class SeedData
    {
        public static void SeedFortgeschrittenenQuiz(ApplicationDbContext context)
        {
            #region FortgeschrittenenQuiz

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

            #endregion

            #region AnfaengerQuiz

            if (!context.Quizzes.Any(x => x.Title == "Anfänger Quiz"))
            {
                var quiz = new Quiz
                {
                    Title = "Anfänger Quiz",
                    Questions = new List<Question>()
                };


                context.Quizzes.AddAsync(quiz);
                context.SaveChanges();

                #region Question

                var question = new Question
                {
                    Text = "Was bedeutet die Abkürzung HTML?",
                    AnswerText =
                        "Hypertext Markup Language wird mit HTML abgekürzt und ist eine textbasierte Auszeichnungssprache zur Strukturierung digitaler Dokumente, wie zum Beispiel Texte mit Hyperlinks, Bildern sowie anderen Inhalten.",
                    ImagePath =
                        "http://byte.at/wp-content/uploads/2012/05/html-400x300.jpg",
                    Position = 1,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "Hypertext Marking Language"},
                        new Option {OptionText = "Hypertext Mark Language"},
                        new Option {OptionText = "Hypertext Markup Language"},
                        new Option {OptionText = "Hypertext Manuell Language"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == "Hypertext Markup Language");
                context.SaveChanges();

                #endregion

                #region Question

                question = new Question
                {
                    Text = "Die Grundstruktur einer Webseite besteht aus <html>, <head>, <title> und <body>. Welches Element enthält den gesamten zusehenden Seiteninhalt?",
                    AnswerText =
                        "<body> kennzeichnet den Anfang und das Ende des sichtbaren Webseiteninhalts und beinhaltet alle Informationen, die man veröffentlichen will. Der Browser veranschaulicht nur den Inhalt zwischen dem öffnenden und schließenden body-Tag im Browserfenster.",
                    ImagePath =
                        "http://byte.at/wp-content/uploads/2012/05/html-400x300.jpg",
                    Position = 2,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "<html>"},
                        new Option {OptionText = "<head>"},
                        new Option {OptionText = "<title>"},
                        new Option {OptionText = "<body>"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == "<body>");
                context.SaveChanges();

                #endregion

            }
            #endregion

            #region ProfiQuiz

            if (!context.Quizzes.Any(x => x.Title == "Profi Quiz"))
            {
                var quiz = new Quiz
                {
                    Title = "Profi Quiz",
                    Questions = new List<Question>()
                };


                context.Quizzes.AddAsync(quiz);
                context.SaveChanges();

                #region Question

                var question = new Question
                {
                    Text = "Welche Aussage ist falsch?",
                    AnswerText =
                        "Mit JavaScript kann das Design einer Webseite nicht verändert werden, weil CSS diese Aufgabe erfüllt.",
                    ImagePath =
                        "https://image.flaticon.com/icons/svg/29/29582.svg",
                    Position = 1,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "Mit JavaScript kann man auf das HTML-Dokument zugreifen"},
                        new Option {OptionText = "Mit JavaScript kann das Design einer Webseite verändert werden"},
                        new Option {OptionText = "Mit JavaScript können 3D-Spiele erstellt werden"},
                        new Option {OptionText = "Mit JavaScript können dynamische Änderung des HTML-Dokuments vorgenommen werden"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == "Mit JavaScript kann das Design einer Webseite verändert werden");
                context.SaveChanges();

                #endregion

                #region Question

                question = new Question
                {
                    Text = "In welchem Element muss JavaScript eingebettet werden?",
                    AnswerText =
                        "JavaScript wird im script-Element eingebunden. Die anderen Auswahlmöglichkeiten sind erfunden.",
                    ImagePath =
                        "https://image.flaticon.com/icons/svg/29/29582.svg",
                    Position = 2,
                    Options = new List<Option>
                    {
                        new Option {OptionText = "script"},
                        new Option {OptionText = "java"},
                        new Option {OptionText = "javascript"},
                        new Option {OptionText = "js"}
                    }
                };

                quiz.Questions.Add(question);

                context.Quizzes.Update(quiz);
                context.SaveChanges();

                question.CorrectOption = question.Options.FirstOrDefault(x => x.OptionText == "script");
                context.SaveChanges();

                #endregion

            }
            #endregion
        }

    }
}
