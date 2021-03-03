using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Login
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        //FORM LOGIN
        public DataTable uSUARIO_Sesion(E_LOGIN sender)
        {
            DataTable dt = new DataTable();
            
            MySqlCommand cmd = new MySqlCommand("SP_LOGIN",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("usuario", sender.Usuario);
            cmd.Parameters.AddWithValue("passwords", sender.Contra);       
            MySqlDataAdapter adaptarinfo = new MySqlDataAdapter(cmd);
            adaptarinfo.Fill(dt);
            conexion.Close();
            return dt;
        }
        //PANEL USUARIOS
        public DataTable listarusuarios2(string buscar)
        {
            DataTable dt = new DataTable();
            MySqlDataReader leerfilas;
            MySqlCommand cmd = new MySqlCommand("SP_VER_USUARIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("Searchuser", buscar);
            leerfilas = cmd.ExecuteReader();
            dt.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return dt;
        }
        //PERFIL
        public List<E_Datos_Perfil> cargardatosperfil(int IDUSER)
        {
            List<E_Datos_Perfil> lista = new List<E_Datos_Perfil>();
            MySqlDataReader leerrows = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VER_DATOS_PERFIL", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", IDUSER);
                leerrows = cmd.ExecuteReader();
                while (leerrows.Read())
                {
                    lista.Add(new E_Datos_Perfil()
                    {
                        Nombre = leerrows.GetString(0),
                        Apellido = leerrows.GetString(1),
                        Telefono  = leerrows.GetString(2),
                        Usuario = leerrows.GetString(3),
                        Pass = leerrows.GetString(4),
                        Fecha_Ingreso = leerrows.GetDateTime(5)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    leerrows.Close();
                }
            }
            return lista;
        }
        public void EditarContrasena(int iduser, string pass)
        {
            MySqlCommand cmd = new MySqlCommand("SP_EDITAR_CONTRASENA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("IDUSER", iduser);
            cmd.Parameters.AddWithValue("PASS", pass);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarPerfil(int iduser, string telefono)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "UPDATE Usuarios SET Telefono = @TELEFONO WHERE ID_Usuario = @IDUSER";
            cmd.Parameters.AddWithValue("@IDUSER", iduser);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        
    }
}

















//public List<E_Usuarios_LEFTJOIN> ListarUsuarios(string buscar)
//{
//    MySqlDataReader leerrows;
//    MySqlCommand cmd = new MySqlCommand("SP_VER_USUARIOS", conexion);
//    cmd.CommandType = CommandType.StoredProcedure;
//    conexion.Open();
//    cmd.Parameters.AddWithValue("Searchuser", buscar);
//    leerrows = cmd.ExecuteReader();
//    List<E_Usuarios_LEFTJOIN> lista = new List<E_Usuarios_LEFTJOIN>();
//    while(leerrows.Read())
//    {
//        lista.Add(new E_Usuarios_LEFTJOIN()
//        {
//            ID_Usuario = leerrows.GetInt32(0),
//            Nombre = leerrows.GetString(1),
//            Apellido = leerrows.GetString(2),
//            Sexo = leerrows.GetString(3),
//            Dui = leerrows.GetString(4),
//            Telefono = leerrows.GetString(5),
//            Usuario = leerrows.GetString(6),
//            Pass = leerrows.GetString(7),
//            Fecha_Ingreso = leerrows.GetDateTime(8),
//            ID_Estado_Usuario = leerrows.GetInt32(9),
//            Estado = leerrows.GetString(10),
//            ID_Rol = leerrows.GetInt32(11),
//            Rol = leerrows.GetString(12),
//            ID_Cuota = leerrows.GetInt32(13),
//            Cuota = leerrows.GetDecimal(14)

//        });
//    }
//    conexion.Close();
//    leerrows.Close();
//    return lista;
//}