using System;
using System.Collections.Generic;
using System.Text;
using Web.Models.DTO;

namespace Web.BLL.Services.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<CandidateVote> GetCandidateVotes();
    }
}
