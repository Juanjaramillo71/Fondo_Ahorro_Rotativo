using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Fondo_Ahorro_App.Persistencia;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Frontend.Pages
{
    public class LoginClienteModel : PageModel
    {   
        [BindProperty]
        public string CedulaU { get; set; }
        [BindProperty]
        public string ContrasenaU { get; set; }

        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public LoginClienteModel(IRepositorioCliente repositorioC)
        {
            _repo= repositorioC;
        }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            /*TempData["Message"] = $"Nombre: {NombreU}, Contraseña: {ContrasenaU}";
            return new RedirectToPageResult("/Privacy");*/

             if (string.IsNullOrEmpty(CedulaU) || string.IsNullOrEmpty(ContrasenaU))
            {
                return Page();
            }
            var cliente = _repo.LoginCliente(CedulaU, ContrasenaU);
            
            if (cliente == null)
            {
                return RedirectToPage("./LoginCliente");
            } 
            //return RedirectToPage("/Privacy");
            var cU = cliente.Id;

            return RedirectToPage("/Cuenta/MostrarCuenta", new { IdCliente = cU });

           
        
         //HttpContext.Session.SetString("CedulaUsuario", CedulaU);
        //return RedirectToPage("/Cuenta/MostrarCuenta");



    
           // return RedirectToPage("/Cuenta/MostrarCuenta");
        }
    }
}