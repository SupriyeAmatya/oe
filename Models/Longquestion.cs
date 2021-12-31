using System;
using System.Collections.Generic;

#nullable disable

namespace oe.Models
{
    public partial class Longquestion
    {
        public int LongquestionId { get; set; }
        public string LongquestionText { get; set; }
        public string Longanswer { get; set; }
        public string Longanswerupload { get; set; }
        public int? ExamId { get; set; }
    }
}
