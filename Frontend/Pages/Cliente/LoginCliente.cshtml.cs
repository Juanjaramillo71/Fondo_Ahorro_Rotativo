using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using TallerMecanica.Persistencia;

namespace Frontend.Pages
{
    public class LoginClienteModel : PageModel
    {   
        [BindProperty]
        public string NombreU { get; set; }
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

             if (string.IsNullOrEmpty(NombreU) || string.IsNullOrEmpty(ContrasenaU))
            {
                return Page();
            }
            var cliente = _repo.LoginCliente(NombreU, ContrasenaU);
            
            if (cliente == null)
            {
                return RedirectToPage("./LoginCliente");
            } 
            return new RedirectToPageResult("/Privacy");
        }
    }
}