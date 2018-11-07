using GiftVoting.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GiftVoting.DAL.Data
{
    public class GiftVotingDbContext : DbContext 
    {
        public GiftVotingDbContext()
        {

        }

        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet <Vote> Votes { get; set; }
    }
}
