using OccasionInvitation.Domain.Entites;
using System.Data.Entity;

namespace OccasionInvitation.Infrastructure.DatabaseContext
{
    public class OccasionInvitationDbContext : DbContext
    {
        public OccasionInvitationDbContext()
        {
            
        }

        public DbSet<Person> People { get; set; }
    }
}
