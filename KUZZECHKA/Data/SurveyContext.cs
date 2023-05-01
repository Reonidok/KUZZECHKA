using KUZZECHKA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KUZZECHKA.Data
{
    public class SurveyContext : IdentityDbContext<IdentityUser>
    {
        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options){}

        public DbSet<SurveyResult> SurveyResults { get; set; }
    }
}
