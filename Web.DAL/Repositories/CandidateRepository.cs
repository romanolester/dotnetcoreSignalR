using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Base;
using Web.DAL.Context;
using Web.DAL.Repositories.Base.Interfaces;
using Web.Models.DTO;
using Web.Models.Entities;

namespace Web.DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(VoteDbContext dbContext) : 
            base(dbContext)
        {

        }

        public IEnumerable<CandidateVote> GetCandidateVotes()
        {
            return _dbContext.Set<CandidateVote>();
        }
    }
}
