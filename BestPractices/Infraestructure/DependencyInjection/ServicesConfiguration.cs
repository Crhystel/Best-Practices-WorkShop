using Best_Practices.Controllers;
using Best_Practices.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.DependencyInjection
{
    public class ServicesConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Changed from AddTransient to AddSingleton.
            // Ensures the repository instance stays alive for the entire application lifetime,
            // acting as a consistent in-memory database.
            services.AddSingleton<IVehicleRepository, MyVehiclesRepository>();
        }
    }
}
