namespace Hiburan.Models
{
    public class QuizProgress
    {
        public int Id { get; set; }
        public Quiz Quiz { get; set; }
        public bool InProgress { get; set; }
    }
}
