using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Base;
using Web.DAL.Context;
using Web.DAL.Repositories.Base.Interfaces;
using Web.Models.Entities;

namespace Web.DAL.Repositories
{
    public class VoteRepository : 
        GenericRepository<Vote>, 
        IVoteRepository
    {
        public VoteRepository(VoteDbContext dbContext) : 
            base(dbContext)
        {

        }
    }                        
}
