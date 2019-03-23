using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models.Entities
{
    public class Vote
    {
        public Guid Id { get; set; }
        public Guid CandidateId { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
