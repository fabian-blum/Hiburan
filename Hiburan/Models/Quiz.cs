using System.Collections.Generic;

namespace Hiburan.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public virtual List<Question> Questions { get; set; } = new List<Question>();
    }
}
