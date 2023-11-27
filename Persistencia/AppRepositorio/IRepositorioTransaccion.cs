using System.Collections.Generic;
using Dominio;

namespace Fondo_Ahorro_App.Persistencia
{
 public interface IRepositorioTransaccion
 {
      //IEnumerable<Transaccion> SetTransaccion();
      Transaccion SetTransaccion(Transaccion transaccion);
    /*  Revision AddRevision(Revision revision;
      
      Tecnico UpdateTecnico(Tecnico tecnico);
      void DeleteTecnico(int Id_Tecnico);
      Tecnico GetTecnico(int Id_Tecnico);*/
 }

}