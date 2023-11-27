using System;
using System.Collections.Generic;
using Dominio;
using Microsoft.EntityFrameworkCore;


namespace Fondo_Ahorro_App.Persistencia
{
    public class ApppContext: DbContext
    {
        private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BaseDatos;Integrated Security=True;";
        //public DbSet<Persona> personas {get; set;}
        //public DbSet<Vehiculo> vehiculos {get; set;}
       // public DbSet<Tecnico> tecnicos {get; set;}
        public DbSet<Cliente> clientes {get; set;}
        public DbSet<Cuenta> cuentas {get; set;}
        public DbSet<Transaccion> transacciones { get; set; }

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


