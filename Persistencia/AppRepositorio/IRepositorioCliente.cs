using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioCliente
 {
      IEnumerable<Cliente> GetAllClientes();
      Cliente AddCliente(Cliente cliente);
      Cliente UpdateCliente(Cliente cliente);
      void DeleteCliente(int Id_Cliente);
      Cliente GetCliente(int Id_Cliente);
     // Cliente LoginCliente(Cliente cliente);
      Cliente LoginCliente(string nombre, string contraseña);
 }

}
