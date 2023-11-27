using System.Collections.Generic;
using Dominio;
using System.Linq; 

namespace Fondo_Ahorro_App.Persistencia
{
    public class RepositorioTransaccion : IRepositorioTransaccion
    {
      private readonly ApppContext _appContext; 
      public RepositorioTransaccion(ApppContext appContext)
          {
               _appContext = appContext;
          }
   
    Transaccion IRepositorioTransaccion.SetTransaccion(Transaccion transaccion)
    {

        var pagoAdicionado=_appContext?.transacciones?.Add(transaccion);
       _appContext.SaveChanges();
       return pagoAdicionado.Entity; 
    }   
    }
}