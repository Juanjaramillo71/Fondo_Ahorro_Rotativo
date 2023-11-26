using System;
using Dominio;
using Microsoft.EntityFrameworkCore;


namespace TallerMecanica.Persistencia
{
    public class ApppContext: DbContext
    {
        private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BaseDatos;Integrated Security=True;";
        //public DbSet<Persona> personas {get; set;}
        //public DbSet<Vehiculo> vehiculos {get; set;}
       // public DbSet<Tecnico> tecnicos {get; set;}
        public DbSet<Cliente> clientes {get; set;}
        //public DbSet<Historial> historiales{get;set;}
        //public DbSet<Reparacion> reparaciones{get;set;}
        public ApppContext()
        {}

        public ApppContext(DbContextOptions<ApppContext> options):base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}


