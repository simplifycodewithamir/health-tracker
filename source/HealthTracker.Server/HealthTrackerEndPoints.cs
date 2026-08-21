namespace HealthTracker.Server;

internal static class HealthTrackerEndPoints
{
    private const string BasePath = "/healthtracker";

    internal static void MapHealthTrackerEndPoints(this WebApplication app)
    {
        var group = app.MapGroup(BasePath);

        group.MapGet("/dummy-end-point", () => Results.Ok("HealthTracker API is running."))
            .AllowAnonymous()
            .WithName("CheckAppHealth");
    }
}
