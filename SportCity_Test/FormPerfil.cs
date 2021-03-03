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
    public partial class FormPerfil : FormBaseInvocado
    {
        public FormPerfil()
        {
            InitializeComponent();
        }
        N_Login neg = new N_Login();
        public DataSet ds = new DataSet();
        List<E_Datos_Perfil> list = new List<E_Datos_Perfil>();
        void CargarDatos(int iduser)
        {
            list = neg.ListarDatosPerfil(iduser);
            ds = ToDataSet<E_Datos_Perfil>(list);
            txtnombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();
            txtapellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString().Trim();
            txtelefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString().Trim();
            txtcorreouser.Text = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
            txtfechaingreso.Text = ds.Tables[0].Rows[0]["Fecha_Ingreso"].ToString().Trim();
            defaultview();
        }
        void defaultview()
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtelefono.Enabled = false;
            txtcorreouser.Enabled = false;
            txtfechaingreso.Enabled = false;
            btnguardar.Visible = false;
            btnEDITAR.Visible = true;
        }
        void edit()
        {
            btnEDITAR.Visible = false;
            btnguardar.Visible = true;
            txtelefono.Enabled = true;
            txtelefono.Focus();
        }
        private void FormPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(1);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
            
        }

        private void btncambiarpass_Click(object sender, EventArgs e)
        {
            try
            {
                FormCambiarPass fo = new FormCambiarPass();
                fo.antiguapass = ds.Tables[0].Rows[0]["Pass"].ToString().Trim();
                fo.ShowDialog();
                //ds = fo.data;
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
            
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                edit();
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtelefono.Text))
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                    CargarDatos(1);
                }
                else
                {
                    DialogResult result = new DialogResult();
                    FormPregunta fr = new FormPregunta("PREGUNTA SERIA", "DE VERDAD DESEA GUARDAR CAMBIOS ?");
                    result = fr.ShowDialog();
                    if (result == DialogResult.OK)
                    {//Login.Id_Usuario = 1
                        neg.EditarPerfil(1, txtelefono.Text);
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE EDITO CORRECTAMENTE.");
                        CargarDatos(1);
                    }
                    else if(result == DialogResult.Cancel)
                    {
                        CargarDatos(1);
                    }
                }
                
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
        }

        private void BTNdesactivar_Click(object sender, EventArgs e)
        {

        }
    }
}
