using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Hiburan.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<QuizProgress> QuizProgresses { get; set; }
    }
}
