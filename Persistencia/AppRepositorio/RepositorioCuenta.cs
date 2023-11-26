using System.Collections.Generic;
using Dominio;

namespace Fondo_Ahorro_App.Persistencia
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