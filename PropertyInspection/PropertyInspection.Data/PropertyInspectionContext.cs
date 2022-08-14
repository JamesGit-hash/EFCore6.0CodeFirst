using Microsoft.EntityFrameworkCore;

namespace PropertyInspection.Data
{
    public class PropertyInspectionContext : DbContext
    {
        public PropertyInspectionContext(DbContextOptions<PropertyInspectionContext> options): base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyTest>()
                .HasIndex(x => x.PostCode)
                .IsClustered(false);

            modelBuilder.Entity<PropertyTest>()
                .Property(x => x.CreatedTime)
                .HasComputedColumnSql("GetUtcDate()");
        }

        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<PropertyTest> Properties { get; set; }
    }
}