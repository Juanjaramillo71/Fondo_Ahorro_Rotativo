using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Fondo_Ahorro_App.Persistencia;
using Microsoft.AspNetCore.Http;

namespace Frontend.Pages
{
    public class MostrarCuentaModel : PageModel
    {
        private readonly IRepositorioCuenta _reposC;
        private readonly IRepositorioCliente _repoCliente;
        public IEnumerable<Cuenta> Cuentas{get;set;}
         public Cliente Cliente { get; set; } 
        public MostrarCuentaModel(IRepositorioCuenta repoCuenta, IRepositorioCliente repoCliente)
        {
            _reposC = repoCuenta;
            _repoCliente = repoCliente;
        }
       public void OnGet(string nombreU)
        {
            var nombreUsuario = HttpContext.Session.GetString("NombreUsuario");
            ViewData["NombreUsuario"] = nombreUsuario;


           /* if(!string.IsNullOrEmpty(nombreU))
             {
                Cliente = _repoCliente.GetCliente(nombreU); // Buscar cliente
                ViewData["NombreUsuario"] = Cliente.Nombre;  
             }

            */
            
            /*ViewData["NombreUsuario"] = cliente.NombreU;   */      
            
            /*cuentas = _reposC.GetCuenta();
            foreach(var cuenta in Cuentas )
            {
                Console.WriteLine(cuenta.Titular);
            }*/
        }
    }
}
