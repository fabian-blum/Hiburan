using System.Collections.Generic;

namespace Hiburan.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int Position { get; set; }
        public string Text { get; set; }
        public string AnswerText { get; set; }
        public virtual List<Option> Options { get; set; } = new List<Option>();

        public int? CorrectOptionId { get; set; }
        public virtual Option CorrectOption { get; set; }

        public string ImagePath { get; set; }
    }
}
