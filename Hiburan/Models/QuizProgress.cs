using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hiburan.Models
{
    public class QuizProgress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Quiz Quiz { get; set; }
        public bool InProgress { get; set; }
    }
}
