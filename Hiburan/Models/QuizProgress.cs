﻿namespace Hiburan.Models
{
    public class QuizProgress
    {
        public int Id { get; set; }

        public virtual Quiz Quiz { get; set; }
        public bool Finished { get; set; }
        public int Position { get; set; }
    }
}
