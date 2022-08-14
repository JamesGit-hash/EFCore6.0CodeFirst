using Microsoft.EntityFrameworkCore;

namespace PropertyInspection.Data
{
    public class PropertyInspectionContext : DbContext
    {
        public PropertyInspectionContext(DbContextOptions<PropertyInspectionContext> options): base(options)
        {
            Database.Migrate();
        }

        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Agent> Agents { get; set; }
    }
}