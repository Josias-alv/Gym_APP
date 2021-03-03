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
using CapaEntidades;
using CapaNegocio;

namespace SportCity_Test
{
    public partial class FormEstado_Usuario : FormBaseInvocado
    {
        public FormEstado_Usuario()
        {
            InitializeComponent();
            MostrarEstado("");
        }
        N_Estado_Usuario neg = new N_Estado_Usuario();
        private int idEstado;
        private bool editarse = false;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MostrarEstado(string buscar)
        {
            Grid_Estado.DataSource = null;
            Grid_Estado.Refresh();
            Grid_Estado.Update();
            Grid_Estado.DataSource = neg.Listar_Estados(buscar);
            Grid_Estado.ClearSelection();

        }
        void limpiar()
        {
            editarse = false;
            txtnombreestado.ResetText();
            Grid_Estado.ClearSelection();
        }
        private void FormEstado_Usuario_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtfiltro_OnValueChanged(object sender, EventArgs e)
        {
            MostrarEstado(txtfiltro.Text);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(Grid_Estado.SelectedRows.Count > 0)
            {
                editarse = true;
                idEstado = Convert.ToInt32(Grid_Estado.CurrentRow.Cells["ID_Estado"].Value.ToString());
                txtnombreestado.Text = Grid_Estado.CurrentRow.Cells["Nombre_Estado"].Value.ToString();
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
                    if (string.IsNullOrEmpty(txtnombreestado.Text))
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                    }
                    else
                    {
                        E_EstadoUsuario entities = new E_EstadoUsuario();
                        entities.ID_Estado = idEstado;
                        entities.Nombre_Estado = txtnombreestado.Text;
                        neg.EditarEstado(entities);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE EDITO EL REGISTRO CORRECTAMENTE.");
                        MostrarEstado("");
                        limpiar();
                    }
                    
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
            else if(editarse == false)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtnombreestado.Text))
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                    }
                    else
                    {
                        E_EstadoUsuario entities = new E_EstadoUsuario();
                        entities.Nombre_Estado = txtnombreestado.Text;
                        neg.AgregarEstado(entities);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE AGREGO EL REGISTRO CORRECTAMENTE.");
                        MostrarEstado("");
                        limpiar();
                    }
                   
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                FormPregunta fo = new FormPregunta("PREGUNTA SERIA", "DESEA ELIMINAR ESTE REGISTRO ?");
                result = fo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (Grid_Estado.SelectedRows.Count > 0)
                    {
                        E_EstadoUsuario entities = new E_EstadoUsuario();
                        entities.ID_Estado = Convert.ToInt32(Grid_Estado.CurrentRow.Cells["ID_Estado"].Value.ToString());
                        neg.EliminarEstado(entities);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE ELIMINO EL REGISTRO CORRECTAMENTE.");
                        MostrarEstado("");
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
