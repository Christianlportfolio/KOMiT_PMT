using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KOMiT.DataAccess.Persistence;

public static class DatabaseContextRegistration
{
    public static void AddKOMiTApp(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>((provider, options) => options.UseSqlServer(provider.GetRequiredService<IConfiguration>().GetConnectionString("KOMiTConnectionString")));
        services.AddTransient<DatabaseContext>();
    }
}
