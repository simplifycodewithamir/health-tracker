namespace HealthTracker.Server
{
    internal static class HealthTrackerEndPoints
    {
        internal static void MapTrackerEndPoints(this WebApplication app)
        {
            app.MapGet("/api/health", () => Results.Ok("HealthTracker API is running."))
                .CacheOutput(p => p.Expire(TimeSpan.FromSeconds(5)))
                .WithName("CheckAppHealth"); ;
        }
    }
}
