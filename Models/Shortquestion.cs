using System;
using System.Collections.Generic;

#nullable disable

namespace oe.Models
{
    public partial class Shortquestion
    {
        public int ShortquestionId { get; set; }
        public string ShortquestionText { get; set; }
        public string Shortanswer { get; set; }
        public string Shortanswerupload { get; set; }
        public int? ExamId { get; set; }
    }
}
