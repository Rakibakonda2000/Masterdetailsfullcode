using Microsoft.EntityFrameworkCore;

namespace Masterdetails.Models
{
    public class DbApplicant : DbContext
    {
        public DbApplicant(DbContextOptions<DbApplicant> options) : base(options) { }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicantEx> ApplicantsEx { get; set; }
   
    }
}
