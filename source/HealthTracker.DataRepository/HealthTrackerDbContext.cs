using Microsoft.EntityFrameworkCore;

namespace HealthTracker.DataRepository
{
    internal class HealthTrackerDbContext(DbContextOptions<HealthTrackerDbContext> options) : DbContext(options)
    {
    }
}
