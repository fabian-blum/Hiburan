using System.Collections.Generic;

namespace Hiburan.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Text { get; set; }
        public List<Option> Options { get; set; }
        public Option CorrectOption { get; set; }
        public string ImagePath { get; set; }
    }
}
