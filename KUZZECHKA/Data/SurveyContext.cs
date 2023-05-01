using KUZZECHKA.Models;
using Microsoft.EntityFrameworkCore;

namespace KUZZECHKA.Data
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options){}

        public DbSet<SurveyResult> SurveyResults { get; set; }
    }
}
