using System;
using Dominio;
using Fondo_Ahorro_App;
using Fondo_Ahorro_App.Persistencia;

namespace Consola
{
    class Program
    {
        private static IRepositorioCliente _RepoC = new RepositorioCliente(new ApppContext());
        static void Main(string[] args)
        {           
            AdicionarCliente();
         
        }
        private static void AdicionarCliente()
        {
            Cliente c = new Cliente();
            c.Nombre = "Juan David";
            c.Apellido = "Jaramillo Mena";
            c.Cedula = 1061717317;
            c.Edad = 34;
            c.Direccion="Barrio El Cedro";
            c.NumeroTelefono = "3225914053";
            c.genero = "Masculino";
            _RepoC.AddCliente(c);
            
        }  


    }

}
