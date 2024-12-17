using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace SportNutrition.DAL;
    public class ApplicationContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
    }