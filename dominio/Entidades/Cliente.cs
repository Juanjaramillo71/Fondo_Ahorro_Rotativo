using System;

namespace Dominio
{
    public class Cliente
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public int Edad {get;set;}
        public string Cedula {get;set;}
        public string Direccion {get;set;}
        public string Email {get;set;}
        public string Telefono {get;set;}
        public string Genero {get;set;}
        public string Contraseña {get;set;}
        public DateTime FechaNacimiento { get; set; }
    }

}