using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Fondo_Ahorro_App.Persistencia;


namespace Frontend.Pages
{
    public class CrearClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        private readonly IRepositorioCuenta _repoCu;
        public IEnumerable<Cuenta> Cuentas{get;set;}
        public Cliente cliente {get;set;}

        public CrearClienteModel(IRepositorioCliente repositorioC, IRepositorioCuenta repoCuenta)
        {
            _repo= repositorioC;
            _repoCu = repoCuenta;
        }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost(Cliente cliente)
        {
            //Console.WriteLine("hola");
            _repo.AddCliente(cliente);
            var Cc = cliente.Cedula;
            _repoCu.AddCuenta(Cc);

            //return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
            return new RedirectToPageResult("/Cuenta/CrearCuenta");
        }
    }
}
