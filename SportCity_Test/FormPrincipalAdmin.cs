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

namespace SportCity_Test
{
    public partial class FormPrincipalAdmin : FormPrincipalBase
    {
        public FormPrincipalAdmin()
        {
            InitializeComponent();
            AbrirForms(new FormDefault());
        }
        public void SeleccionamosBotones(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnUsuarios.Textcolor = Color.White;
            btnPerfil.Textcolor = Color.White;
            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(34, 155, 90);
                sender.Activecolor = Color.FromArgb(40,40,40);
                sender.BackColor = Color.FromArgb(40, 40, 40);
                sender.OnHovercolor = Color.FromArgb(40, 40, 40);
            }
        }
        public void ResetButtons()
        {
            btnPerfil.Textcolor = Color.White;
            btnPerfil.Textcolor = Color.White;
            btncerrarsesion.Textcolor = Color.White;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SeleccionamosBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            label1.Text = "Usuarios";
            AbrirForms(new Usuarios());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            SeleccionamosBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            label1.Text = "Perfil";
            AbrirForms(new FormPerfil());
        }
        private Form formActivo = null;
        private void AbrirForms(Form FormHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = FormHijo;
            //le decimos que es un formulario hijo
            FormHijo.TopLevel = false;
            //le decimos que habarque todo el panel
            FormHijo.Dock = DockStyle.Fill;
            //agregando el form
            PanelInvocar.Controls.Add(FormHijo);
            //obtiene sus datos
            PanelInvocar.Tag = FormHijo;
            //poniendolo adelante
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormDefault());
            ResetButtons();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            SeleccionamosBotones((Bunifu.Framework.UI.BunifuFlatButton)sender); 
            DialogResult result = new DialogResult();
            FormPregunta abj = new FormPregunta("PREGUNTA SERIA", "DE VERDAD DESEA CERRAR SESION ?");
            result = abj.ShowDialog();
            if(result == DialogResult.OK)
            {
                Login fo = new Login();
                this.Hide();
                fo.Show();
            }
        }
    }
}
