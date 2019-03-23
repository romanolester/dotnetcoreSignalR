using System;
using System.Collections.Generic;
using System.Text;
using Web.BLL.Services.Interfaces;
using Web.DAL.Repositories.Base.Interfaces;
using Web.Models.Entities;

namespace Web.BLL.Services
{
    public class VoteService : IVoteService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IVoteRepository _voteRepository;

        public VoteService(
            ICandidateRepository candidateRepository, 
            IVoteRepository voteRepository)
        {
            _candidateRepository = candidateRepository;
            _voteRepository = voteRepository;
        }

        public bool Vote(Guid candidateId)
        {
            if (candidateId == Guid.Empty)
            {
                return false;
            }

            var candidate = _candidateRepository.Find(candidateId);

            if (candidate == null)
            {
                return false;
            }

            _voteRepository.Create(new Vote
            {
                CandidateId = candidateId
            });

            _voteRepository.Complete();

            return true;
        }
    }
}
