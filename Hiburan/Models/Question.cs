using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hiburan.Models
{
    public class Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Position { get; set; }
        public string Text { get; set; }
        public string AnswerText { get; set; }
        public List<Option> Options { get; set; }

        public int? CorrectOptionId { get; set; }
        public Option CorrectOption { get; set; }

        public string ImagePath { get; set; }
    }
}
