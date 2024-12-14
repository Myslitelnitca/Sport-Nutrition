using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        
        public DbSet<CategoryDb> Categories { get; set; }
        public DbSet<NutritionDb> Nutritions { get; set; }
        public DbSet<OrderDb> Orders { get; set; }
        public DbSet<PicturesSportDb> PicturesSports { get; set; }
        public DbSet<UserDb> Users { get; set; }
        public DbSet<RequestDb> Requests { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
