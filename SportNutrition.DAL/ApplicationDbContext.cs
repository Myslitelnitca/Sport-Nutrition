using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace SportNutrition.DAL
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
