using Microsoft.EntityFrameworkCore;
using SistemaGestionHorarios.Domain;

namespace SistemaGestionHorarios.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
    }
}