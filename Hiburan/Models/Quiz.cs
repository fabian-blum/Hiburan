using System.Collections.Generic;

namespace Hiburan.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; }
    }
}
