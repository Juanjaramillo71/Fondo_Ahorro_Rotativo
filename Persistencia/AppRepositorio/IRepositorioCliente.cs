using System.Collections.Generic;
using Dominio;

namespace Fondo_Ahorro_App.Persistencia
{
 public interface IRepositorioCliente
 {
      IEnumerable<Cliente> GetAllClientes();
      Cliente AddCliente(Cliente cliente);
      Cliente UpdateCliente(Cliente cliente);
      void DeleteCliente(int Id_Cliente);
      Cliente GetCliente(int Id_Cliente);
     // Cliente LoginCliente(Cliente cliente);
      Cliente LoginCliente(string cedula, string contraseña);
 }

}
