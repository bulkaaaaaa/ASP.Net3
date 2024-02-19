using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using WebApplication3.Middleware;
using WebApplication3.Services;

namespace WebApplication3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<ITimeOfDayService, TimeOfDayService>();

            //services.AddTransient<CalcService>();
            services.AddScoped<CalcService>();
            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app)
        {
            
            app.UseMiddleware<TimeOfDayMiddleware>();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
