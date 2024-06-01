using Spark.Library.Routing;

namespace Adwaith1.Pages.Api
{
    public class Example1 : IRoute
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