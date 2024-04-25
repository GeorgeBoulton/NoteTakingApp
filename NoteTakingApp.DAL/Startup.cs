using Microsoft.Extensions.DependencyInjection;
using NoteTakingApp.DAL.Database.Context;

namespace NoteTakingApp.DAL;

public static class Startup
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDbContext<NotesContext>();
    }
}