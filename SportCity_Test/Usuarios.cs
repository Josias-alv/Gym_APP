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
    public partial class Usuarios : FormBaseInvocado
    {
        public Usuarios()
        {
            try
            {
                InitializeComponent();
                Mostrar("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        N_Login neg = new N_Login();
        void accionestabla()
        {

            Grid_Usuarios.Columns["Sexo"].Visible = false;
            Grid_Usuarios.Columns["Contraseña"].Visible = false;
            Grid_Usuarios.Columns["IDEstado_Usuario"].Visible = false;
            Grid_Usuarios.Columns["ID_Rol"].Visible = false;
            Grid_Usuarios.Columns["ID_Cuota"].Visible = false;
            Grid_Usuarios.Columns["DUI"].Visible = false;
            Grid_Usuarios.Columns["Editar"].DisplayIndex = 16;//mover al final
            Grid_Usuarios.Columns["Eliminar"].DisplayIndex = 16;
            Grid_Usuarios.ClearSelection();
        }
        void Mostrar(string buscar)
        {
            Grid_Usuarios.DataSource = null;
            Grid_Usuarios.Refresh();
            Grid_Usuarios.Update();
            Grid_Usuarios.DataSource = neg.ListarUsuarios(buscar);
            accionestabla();
        }

        private void btnfiltro_OnValueChanged(object sender, EventArgs e)
        {
            Mostrar(btnfiltro.Text);
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            FormCuotas fo = new FormCuotas();
            fo.ShowDialog();
        }

        private void Grid_Usuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void Grid_Usuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //permite ver nulls
            Grid_Usuarios.Rows[e.RowIndex].ErrorText = "NUll error";
            e.Cancel = true;
        }

        private void btnrol_Click(object sender, EventArgs e)
        {
            FormRol fo = new FormRol();
            fo.ShowDialog();
        }

        private void btnestadouser_Click(object sender, EventArgs e)
        {
            FormEstado_Usuario FORM = new FormEstado_Usuario();
            FORM.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
