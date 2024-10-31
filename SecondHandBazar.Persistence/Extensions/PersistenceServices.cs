using Microsoft.Extensions.DependencyInjection;
using SecondHandBazar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SecondHandBazar.Application.Repository;
using SecondHandBazar.Persistence.Repository;



namespace SecondHandBazar.Persistence.Extensions
{
    public static class PersistenceServices
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetConnectionString("Development"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
