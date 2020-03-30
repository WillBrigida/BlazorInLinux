using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.Linq;
using TesteWebApi.Models;

namespace TesteWebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers().AddNewtonsoftJson(o => o.
            //SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //services.AddMvc(o => o.EnableEndpointRouting = false).AddNewtonsoftJson(o => o.
            //SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<Data.PessoaDbContext>(options => options.
            UseMySql(_configuration.GetConnectionString("DefaultConnection"), mySqlOptions => mySqlOptions
            .ServerVersion("10.2.11-mariadb")));
            //UseMySql("server=localhost;user id=root;password=Arthuramordopai@02;database=pessoa_db", x => x.ServerVersion("10.2.11-mariadb")));

            services.AddMvc();

            //services.AddResponseCompression(opts =>
            //{
            //    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
            //        new[] { "application/octet-stream" });
            //});

            services.AddScoped<Data.PessoaDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
