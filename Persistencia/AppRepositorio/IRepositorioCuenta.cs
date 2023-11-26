using System.Collections.Generic;
using Dominio;

namespace Fondo_Ahorro_App.Persistencia
{
 public interface IRepositorioCuenta
 {
      IEnumerable<Cuenta> GetCuenta();
 }

}
