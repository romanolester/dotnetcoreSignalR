using System;
using System.Collections.Generic;
using System.Text;

namespace Web.BLL.Services.Interfaces
{
    public interface IVoteService
    {
        bool Vote(Guid candidateId);
    }
}
