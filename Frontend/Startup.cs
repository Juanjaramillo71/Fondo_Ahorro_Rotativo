using System.Reflection;
using System.Buffers;
using System.Runtime.Serialization;
using System.Net.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Fondo_Ahorro_App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;

namespace Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
           // services.AddScoped<IRepositorioTecnico,RepositorioTecnico>();

            services.AddScoped<IRepositorioCliente,RepositorioCliente>();
            services.AddScoped<IRepositorioCuenta,RepositorioCuenta>();
            services.AddScoped<IRepositorioTransaccion,RepositorioTransaccion>();
            services.AddDbContext<ApppContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDistributedMemoryCache(); // Esto es la base para guardar sesiones en memoria

            services.AddSession(options =>{
             options.IdleTimeout = TimeSpan.FromMinutes(20); // Ejemplo: sesión caduca al estar inactivo 20mins
             options.Cookie.HttpOnly = true; 
             options.Cookie.IsEssential = true; 
            });






        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
