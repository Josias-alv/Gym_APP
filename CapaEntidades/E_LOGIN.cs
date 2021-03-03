using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_LOGIN
    {
        public String Usuario { get; set; }
        public string Contra { get; set; }
    }
    public class E_Usuarios_LEFTJOIN 
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string Dui { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int ID_Estado_Usuario { get; set; }
        public string Estado { get; set; }
        public int ID_Rol { get; set; }
        public string Rol { get; set; }
        public int ID_Cuota { get; set; }
        public decimal Cuota { get; set; }
    }
    public class E_Cuotas
    {
        public int ID_Cuota { get; set; }
        public decimal Cuota { get; set; }
    }
    
}
