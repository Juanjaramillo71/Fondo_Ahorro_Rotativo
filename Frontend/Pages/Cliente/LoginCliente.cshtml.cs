using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using TallerMecanica.Persistencia;

namespace Frontend.Pages
{
    public class LoginClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public LoginClienteModel(IRepositorioCliente repositorioC)
        {
            _repo= repositorioC;
        }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost(Cliente cliente)
        {
            _repo.AddCliente(cliente);
            return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
        }
    }
}