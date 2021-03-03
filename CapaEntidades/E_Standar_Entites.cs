using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Standar_Entites
    {
    }
    public class E_Rol 
    {
        public int ID_Rol { get; set; }
        public string Rol { get; set; }
    }
    public class E_EstadoUsuario
    {
        public int ID_Estado { get; set; }
        public string Nombre_Estado { get; set; }
    }
    public class E_Datos_Perfil 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
