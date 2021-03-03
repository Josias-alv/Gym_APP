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
using System.Net;
using CapaEntidades;
using MySql.Data.MySqlClient;

namespace SportCity_Test
{
    public partial class Login : FormbaseLogin
    {
        public Login()
        {
            InitializeComponent();
            
        }
        N_Login neg = new N_Login();
        public static int ID_Usuario;
        private  void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://www.google.com";
                bool coneccionwifi = VerificarConexionURL(url);
                if (coneccionwifi == true)
                    logue();
                else
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "PARA QUE EL SISTEMA TENGO UN OPTIMO FUNCIONAMIENTO TIENE QUE ESTAR CONECTADP A INTERNET.");
            }
            catch (MySqlException ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
           
        }
        private  void logue()
        {
            E_LOGIN entitites = new E_LOGIN();
            entitites.Usuario = txtuser.Text.ToLower();
            entitites.Contra = sha256(txtcontra.Text);
            DataTable dt = neg.Usuario_Sesion(entitites);
            DataSet ds = FormbaseLogin.DataTabletoDataset(dt);
            if(ds.Tables[0].Rows.Count == 0)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "CONTRASEÑA O USUARIO INCORRECTOS...");
            }
            else
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["IDEstado_Usuario"].ToString().Trim()) == 1 && Convert.ToInt32(ds.Tables[0].Rows[0]["ID_Rol"].ToString().Trim()) == 1)
                {
                    FomCompletado.Mensaje("CREDENCIALES AUTORIZADAS", "BIENVENIDO ADMINISTRADOR : " + entitites.Usuario.ToUpper());
                    ID_Usuario = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_Usuario"].ToString().Trim());
                    FormPrincipalAdmin form = new FormPrincipalAdmin();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "ESTE USUARIO NO ESTA ACTIVO O ESTE USUARIO NO ES ADMINISTRADOR, CONTACTE A UN ADMINISTRADOR ACTIVO.");
                }
                    
            }
        }
        private bool VerificarConexionURL(string mURL)
        {
            System.Net.WebRequest Peticion = default(System.Net.WebRequest);
            System.Net.HttpWebResponse Respuesta = (HttpWebResponse)default(WebResponse);
            try
            {
                Peticion = System.Net.WebRequest.Create(mURL);
                Respuesta = (HttpWebResponse)Peticion.GetResponse();
                return true;
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                {
                    return false;
                }
                return false;
            }
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string url = "http://www.google.com";
                    bool coneccionwifi = VerificarConexionURL(url);
                    if (coneccionwifi == true)
                        logue();
                    else
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "PARA QUE EL SISTEMA TENGO UN OPTIMO FUNCIONAMIENTO TIENE QUE ESTAR CONECTADP A INTERNET.");
                }
                catch (MySqlException ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
        }
    }
}
