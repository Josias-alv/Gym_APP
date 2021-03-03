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
    public class N_Cuotas
    {
        D_Cuotas data = new D_Cuotas();
        public List<E_Cuotas> Listar_Cuotas()
        {
            return data.listarcuotas();
        }
        public void AgregarCuotas(E_Cuotas sender)
        {
            data.CrearCuota(sender);
        }
        public void EditarCuotas(E_Cuotas sender)
        {
            data.EDITAR_CUOTA(sender);
        }
        public void ElimnarCuota(E_Cuotas sender)
        {
            data.ELIMINAR_CUOTA(sender);
        }

    }
}
