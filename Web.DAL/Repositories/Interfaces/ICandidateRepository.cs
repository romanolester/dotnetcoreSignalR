using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Base.Interfaces;
using Web.Models.DTO;
using Web.Models.Entities;

namespace Web.DAL.Repositories.Base.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        IEnumerable<CandidateVote> GetCandidateVotes();
    }
}
