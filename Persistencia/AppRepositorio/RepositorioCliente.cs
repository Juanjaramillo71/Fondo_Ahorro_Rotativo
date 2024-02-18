using System.Collections.Generic;
using System;
using System.Linq; 
using Dominio;
using Fondo_Ahorro_App.Persistencia;
using System.Threading.Tasks;


namespace Fondo_Ahorro_App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
      private readonly ApppContext _appContext; 
      public RepositorioCliente(ApppContext appContext)
          {
               _appContext = appContext;
          }

      Cliente IRepositorioCliente.AddCliente(Cliente cliente) 
    {
        var clienteAdicionado=_appContext.clientes.Add(cliente);
       _appContext.SaveChanges();
       return clienteAdicionado.Entity;
    }

    void IRepositorioCliente.DeleteCliente(int Idcliente){

        var clienteEncontrado=_appContext.clientes.FirstOrDefault(c=> c.Id == Idcliente);
        if (clienteEncontrado == null)
            return;
        _appContext.clientes.Remove(clienteEncontrado);
        _appContext.SaveChanges();
    }

  
    IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
    {
       return _appContext.clientes;
    }

    Cliente IRepositorioCliente.GetCliente(int Id_Cliente)
    {
      //return _appContext.clientes.FirstOrDefault(c=> c.Nombre == nombre);
      return _appContext.clientes.FirstOrDefault(c=> c.Id == Id_Cliente);
    }

    Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
    {
    var ClienteEncontrado=_appContext.clientes.FirstOrDefault(c=> c.Id == cliente.Id);
    if(ClienteEncontrado!= null)
    { 
       ClienteEncontrado.Nombre= cliente.Nombre;
       ClienteEncontrado.Apellido= cliente.Apellido;
       ClienteEncontrado.Cedula= cliente.Cedula;
       ClienteEncontrado.Direccion= cliente.Direccion;
       ClienteEncontrado.NumeroTelefono= cliente.NumeroTelefono;
       ClienteEncontrado.Edad= cliente.Edad;
       ClienteEncontrado.genero= cliente.genero;
       ClienteEncontrado.Contraseña= cliente.Contraseña;

      _appContext.SaveChanges();
    }
       return ClienteEncontrado; 
    }

    Cliente IRepositorioCliente.LoginCliente(string cedula, string contraseña)
    {
      return _appContext.clientes.FirstOrDefault(c=> c.Cedula == cedula && c.Contraseña == contraseña);
    }
    /*{
      return _appContext.clientes.FirstOrDefault(c=> c.Cedula == cliente.Cedula && c.Contraseña == cliente.Contraseña);

    }*/
    }
}