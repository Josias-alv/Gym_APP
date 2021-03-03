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
    public partial class FormRol : FormBaseInvocado
    {
        public FormRol()
        {
            InitializeComponent();
            MostrarRoles("");

        }
        N_Rol neg = new N_Rol();
        private int idrol;
        private bool editarse = false;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MostrarRoles(string buscar)
        {
            Grid_Rol.DataSource = null;
            Grid_Rol.Refresh();
            Grid_Rol.Update();
            Grid_Rol.DataSource = neg.Listar_Roles(buscar);
            Grid_Rol.ClearSelection();

        }
        void limpiar()
        {
            editarse = false;
            txtnombrerol.ResetText();
            Grid_Rol.ClearSelection();
        }

        private void txtfiltro_OnValueChanged(object sender, EventArgs e)
        {
            MostrarRoles(txtfiltro.Text);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Grid_Rol.SelectedRows.Count > 0)
            {
                editarse = true;
                idrol = Convert.ToInt32(Grid_Rol.CurrentRow.Cells["ID_Rol"].Value.ToString());
                txtnombrerol.Text = Grid_Rol.CurrentRow.Cells["Rol"].Value.ToString();
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
                    if (string.IsNullOrEmpty(txtnombrerol.Text))
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                    }
                    else
                    {
                        E_Rol entitites = new E_Rol();
                        entitites.ID_Rol = idrol;
                        entitites.Rol = txtnombrerol.Text;
                        neg.EditarRol(entitites);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE EDITO EL REGISTRO CORRECTAMENTE.");
                        MostrarRoles("");
                        limpiar();
                    }
                    
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
            else if (editarse == false)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtnombrerol.Text))
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                    }
                    else
                    {
                        E_Rol entitites = new E_Rol();
                        entitites.Rol = txtnombrerol.Text;
                        neg.AgregarRol(entitites);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE AGREGO EL REGISTRO CORRECTAMENTE.");
                        MostrarRoles("");
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
                if(result == DialogResult.OK)
                {
                    if(Grid_Rol.SelectedRows.Count > 0)
                    {
                        E_Rol entities = new E_Rol();
                        entities.ID_Rol = Convert.ToInt32(Grid_Rol.CurrentRow.Cells["ID_Rol"].Value.ToString());
                        neg.EliminarRol(entities);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE ELIMINO EL REGISTRO CORRECTAMENTE.");
                        MostrarRoles("");
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

        private void FormRol_Load(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
