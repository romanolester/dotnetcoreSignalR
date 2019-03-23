using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BLL.Services.Interfaces;

namespace dotnetcodecamp.Hubs
{
    public class Votehub : Hub
    {
        private readonly IVoteService _voteService;

        public Votehub(IVoteService voteService)
        {
            _voteService = voteService;
        }

        public async Task Vote(Guid candidateId, string message)
        {
            var result = _voteService.Vote(candidateId);

            if (result)
            {
                await Clients.All.SendAsync("NewVote", candidateId);
                await NotifyVoters(message);
            }
        }

        public async Task NotifyVoters(string message = null)
        {
            await Clients.Others.SendAsync(message);
        }
    }
}
