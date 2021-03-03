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
    public partial class FomCompletado : FormBaseInvocado
    {
        public FomCompletado(string titulo, string mensaje)
        {
            InitializeComponent();
            LBTITULO.Text = titulo;
            LBCONTENIDO.Text = mensaje;
        }
        public static void Mensaje(string titulo, string mensaje)
        {
            FomCompletado form = new FomCompletado(titulo,mensaje);
            form.ShowDialog();
        }
        private void BTNACEPTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
