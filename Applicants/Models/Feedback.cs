using System;

namespace Enrollee.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Question { get; set; }
        public DateTime TimeOfFeedbackRequst { get; set; }

        public Feedback()
        {
            Id = Guid.NewGuid();
            TimeOfFeedbackRequst = DateTime.Now;
        }
    }
}
