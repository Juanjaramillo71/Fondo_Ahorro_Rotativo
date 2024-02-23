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
      Cuenta IRepositorioCuenta.AddCuenta(string CedulaCliente) 
    {
            Cuenta cuenta = new Cuenta
            {
                Titular = CedulaCliente,
                Ahorro = 0,
                Intereses = 0,
                SaldoTotal = 0,   
            };

        var cuentaAdicionado=_appContext.cuentas.Add(cuenta);
       _appContext.SaveChanges();
       return cuentaAdicionado.Entity;
    }   
    }
}