using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class N_Estado_Usuario
    {
        D_Estado_Usuario data = new D_Estado_Usuario();
        public List<E_EstadoUsuario> Listar_Estados(string buscar)
        {
            return data.ListarEstado(buscar);
        }
        public void AgregarEstado(E_EstadoUsuario sender)
        {
            data.CrearEstadoUser(sender);
        }
        public void EditarEstado(E_EstadoUsuario sender)
        {
            data.EditarEstadoUser(sender);
        }
        public void EliminarEstado(E_EstadoUsuario sender)
        {
            data.EliminarEstadoUser(sender);
        }
    }
}
