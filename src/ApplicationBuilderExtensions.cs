using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using tcms.Data;

namespace tcms
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder Initialize(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var initializers = serviceScope.ServiceProvider.GetServices<DatabaseSeeder>();

            foreach (var initializer in initializers)
            {
                initializer.Initialize();
            }

            return app;
        }
    }
}
