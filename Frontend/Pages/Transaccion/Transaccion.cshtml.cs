using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Fondo_Ahorro_App.Persistencia;

namespace Frontend.Pages
{
    public class TransaccionModel : PageModel
    {
        private readonly IRepositorioTransaccion _reposT;
        public IEnumerable<Transaccion> Transacciones{get;set;}
        public TransaccionModel(IRepositorioTransaccion repoTrans)
        {
            _reposT = repoTrans;
        }
        public IActionResult OnPost(Transaccion transaccion)
        {
            _reposT.SetTransaccion(transaccion);
            return new RedirectToPageResult("/Transaccion/Transaccion");
        }
        
    }
        /*public void OnGet()
        {
            Transacciones = _reposT.SetTransaccion();
            foreach(var transaccion in Transacciones )
            {
               // Console.WriteLine(transaccion.Fecha);
            }
        }*/
}