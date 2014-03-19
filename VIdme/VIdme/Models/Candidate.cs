using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIdme.Models
{
    public class Candidate
    {
        public Guid CandidateId { get; set; }
        public String Name { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public String Email { get; set; }
    }
}
