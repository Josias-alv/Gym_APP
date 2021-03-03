using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Login
    {
        D_Login data = new D_Login();
        public  DataTable Usuario_Sesion(E_LOGIN sender)
        {
            return data.uSUARIO_Sesion(sender);
        }
        //public List<E_Usuarios_LEFTJOIN> Listar_Usuarios(string buscar)
        //{
        //   // return data.ListarUsuarios(buscar);
        //}
        public DataTable ListarUsuarios(string buscar)
        {
            return data.listarusuarios2(buscar);
        }
        public List<E_Datos_Perfil>ListarDatosPerfil(int iduser)
        {
            return data.cargardatosperfil(iduser);
        }
        public void EditarContra(int iduser, string pass)
        {
            data.EditarContrasena(iduser, pass);
        }
        public void EditarPerfil(int iduser, string telefono)
        {
            data.EditarPerfil(iduser, telefono);
        }
    }
}
