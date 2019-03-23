using System;
using System.Collections.Generic;
using System.Text;
using Web.BLL.Services.Interfaces;
using Web.DAL.Repositories.Base.Interfaces;
using Web.Models.DTO;

namespace Web.BLL.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public IEnumerable<CandidateVote> GetCandidateVotes()
        {
            return _candidateRepository.GetCandidateVotes();
        }
    }
}