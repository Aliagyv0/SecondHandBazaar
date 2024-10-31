using Microsoft.Extensions.DependencyInjection;
using SecondHandBazar.Application.Services;
using SecondHandBazar.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Infrastructure.Extensions
{
    public static class InfanstructureServices
    {
        public static void AddInfanstructureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductServices>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());    
        
        }
    }
}
