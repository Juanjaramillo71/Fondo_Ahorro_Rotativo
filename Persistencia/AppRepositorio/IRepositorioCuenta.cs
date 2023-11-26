using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioCuenta
 {
      IEnumerable<Cuenta> GetCuenta();
 }

}
