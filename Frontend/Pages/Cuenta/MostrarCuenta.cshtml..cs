using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Fondo_Ahorro_App.Persistencia;

namespace Frontend.Pages
{
    public class MostrarCuentaModel : PageModel
    {
        private readonly IRepositorioCuenta _reposC;
        public IEnumerable<Cuenta> Cuentas{get;set;}
        public MostrarCuentaModel(IRepositorioCuenta repoCuenta)
        {
            _reposC = repoCuenta;
        }
        public void OnGet()
        {
            Cuentas = _reposC.GetCuenta();
            foreach(var cuenta in Cuentas )
            {
                Console.WriteLine(cuenta.Titular);
            }
        }
    }
}
