using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportCity_Test.FormsBases;
using CapaNegocio;
using CapaEntidades;

namespace SportCity_Test
{
    public partial class FormCuotas : FormBaseInvocado
    {
        public FormCuotas()
        {
            InitializeComponent();
            Mostrarcuotas();
        }
        N_Cuotas neg = new N_Cuotas();
        private int idcuota;
        private bool editarse = false;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Mostrarcuotas()
        {
            Grid_Cuota.DataSource = null;
            Grid_Cuota.Refresh();
            Grid_Cuota.Update();
            Grid_Cuota.DataSource = neg.Listar_Cuotas();
            Grid_Cuota.ClearSelection();

        }
        void limpiar()
        {
            editarse = false;
            txtCuota.Clear();
            Grid_Cuota.ClearSelection();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            if(Grid_Cuota.SelectedRows.Count > 0)
            {
                editarse = true;
                idcuota = Convert.ToInt32(Grid_Cuota.CurrentRow.Cells["ID_Cuota"].Value.ToString());
                txtCuota.Text = Grid_Cuota.CurrentRow.Cells["Cuota"].Value.ToString();
            }
            else
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "DEBE SELECCIONAR LA FILA QUE DESEA EDITAR.");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(editarse == true)
            {
                try
                {
                    E_Cuotas entities = new E_Cuotas();
                    entities.ID_Cuota = idcuota;
                    entities.Cuota = Convert.ToDecimal(txtCuota.Text);
                    neg.EditarCuotas(entities);
                    FomCompletado.Mensaje("TAREA REALIZADA", "SE EDITO EL REGISTRO CORRECTAMENTE.");
                    Mostrarcuotas();
                    limpiar();
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
            else if( editarse == false)
            {
                try
                {
                    E_Cuotas entities = new E_Cuotas();
                    entities.Cuota = Convert.ToDecimal(txtCuota.Text);
                    neg.AgregarCuotas(entities);
                    FomCompletado.Mensaje("TAREA REALIZADA", "SE AGREGO EL REGISTRO CORRECTAMENTE.");
                    Mostrarcuotas();
                    limpiar();
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                FormPregunta fr = new FormPregunta("PREGUNTA SERIA","DESEA ELIMINAR ESTE REGISTRO ?");
                result = fr.ShowDialog();
                if(result == DialogResult.OK)
                {
                    if (Grid_Cuota.SelectedRows.Count > 0)
                    {
                        E_Cuotas entities = new E_Cuotas();
                        entities.ID_Cuota = Convert.ToInt32(Grid_Cuota.CurrentRow.Cells["ID_Cuota"].Value.ToString());
                        neg.ElimnarCuota(entities);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE ELIMINO EL REGISTRO CORRECTAMENTE.");
                        Mostrarcuotas();
                        limpiar();
                    }
                    else
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "DEBE SELECCIONAR LA FILA QUE DESEA ELIMINAR.");
                    }

                }
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
        }

        private void FormCuotas_Load(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
