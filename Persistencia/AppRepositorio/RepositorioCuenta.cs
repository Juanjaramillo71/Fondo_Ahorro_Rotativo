using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioCuenta : IRepositorioCuenta
    {
      private readonly ApppContext _appContext; 
      public RepositorioCuenta(ApppContext appContext)
          {
               _appContext = appContext;
          }
   
    IEnumerable<Cuenta> IRepositorioCuenta.GetCuenta()
    {
       return _appContext.cuentas;
    }   
    }
}