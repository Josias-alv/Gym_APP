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
    public partial class FormCambiarPass : FormBaseInvocado
    {
        public FormCambiarPass()
        {
            InitializeComponent();

        }
        N_Login neg = new N_Login();
        public string antiguapass;
  
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtantiguacontra.Text) || string.IsNullOrEmpty(txtnuevacontra.Text) || string.IsNullOrEmpty(txtnuvacontraconfirm.Text))
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
            }
            else
            {
                if (FormbaseLogin.sha256(txtantiguacontra.Text) != antiguapass)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "ESA NO ES SU CONTRASEÑA ANTIGUA POR FAVOR VERIFIQUE !.");
                }
                else
                {
                    if (txtnuevacontra.Text != txtnuvacontraconfirm.Text)
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "EL CAMPO (NUEVA CONTRASEÑA) TIENE QUE SER IGUAL AL CAMPO DE (CONFIRMAR NUEVA CONTRASEÑA) POR FAVOR VERIFIQUE !.");
                    }
                    else
                    {
                        string pass_encrypt = FormbaseLogin.sha256(txtnuvacontraconfirm.Text);              
                        neg.EditarContra(1, pass_encrypt);//1 = Login.ID_Usuario
                        FomCompletado.Mensaje("TAREA REALIZADA", "SE CAMBIO SU CONTRASEÑA EXITOSAMENTE.");
                        this.Close();
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
