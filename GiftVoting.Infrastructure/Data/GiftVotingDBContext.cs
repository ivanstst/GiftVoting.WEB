using GiftVoting.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GiftVoting.DAL.Data
{
    public class GiftVotingDbContext : DbContext
    {
        public GiftVotingDbContext()
        {

        }

        public GiftVotingDbContext(DbContextOptions<GiftVotingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Vote> Votes { get; set; }


    }
}
