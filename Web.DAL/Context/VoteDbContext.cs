using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Web.Models.DTO;
using Web.Models.Entities;

namespace Web.DAL.Context
{
    public class VoteDbContext : DbContext
    {
        public VoteDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }
        public virtual DbSet<CandidateVote> CandidateVotes { get; set; }
    }
}
