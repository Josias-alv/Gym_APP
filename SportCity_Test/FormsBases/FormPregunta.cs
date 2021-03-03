using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCity_Test.FormsBases
{
    public partial class FormPregunta : FormBaseInvocado
    {
        public FormPregunta(string titulo, string mensaje)
        {
            InitializeComponent();
            LBTITULO.Text = titulo;
            LBCONTENIDO.Text = mensaje;
        }

        private void BTNACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
