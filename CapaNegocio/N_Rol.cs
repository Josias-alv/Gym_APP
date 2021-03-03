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
    public class N_Rol
    {
        D_Rol data = new D_Rol();
        public List<E_Rol>Listar_Roles(string buscar)
        {
            return data.ListarRoles(buscar);
        }
        public void AgregarRol(E_Rol sender)
        {
            data.CrearRol(sender);
        }
        public void EditarRol(E_Rol sender)
        {
            data.EDITAR_ROL(sender);
        }
        public void EliminarRol(E_Rol sender)
        {
            data.ELIMINAR_ROL(sender);
        }
    }
}
