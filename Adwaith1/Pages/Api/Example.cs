using Spark.Library.Routing;

namespace Timesheets.Pages.Api
{
    public class Example : IRoute
    {
        public void Map(WebApplication app)
        {
            app.MapGet("/api/example", () =>
            {
                return Results.Ok(new { Hello = "World" });
            });
        }
    }
}