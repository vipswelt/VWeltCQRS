using VWelt.Application.Context;
using VWelt.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VWelt.Infrastructure;

public static class RegisterService
{
    public static void ConfigureInfraStructure(this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddDbContext<VWeltDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("VWeltDbConnection"));
        });

        services.AddScoped<IVWeltDbContext>(option => {
           return option.GetService<VWeltDbContext>();
        });

    }
}