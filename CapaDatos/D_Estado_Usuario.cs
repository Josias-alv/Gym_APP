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
    public class D_Estado_Usuario
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_EstadoUsuario> ListarEstado(string buscar)
        {
            List<E_EstadoUsuario> lista = new List<E_EstadoUsuario>();
            MySqlDataReader leerrows = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VER_ESTADOUSUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("BUSCAR", buscar);
                leerrows = cmd.ExecuteReader();
                while (leerrows.Read())
                {
                    lista.Add(new E_EstadoUsuario()
                    {
                        ID_Estado = leerrows.GetInt32(0),
                        Nombre_Estado = leerrows.GetString(1)
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
        public void CrearEstadoUser(E_EstadoUsuario sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_GUARDAR_ESTADOUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("NOMBRE_ESTADO", sender.Nombre_Estado);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarEstadoUser(E_EstadoUsuario sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_EDITAR_ESTADOUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("NOMBRE_ESTADO", sender.Nombre_Estado);
            cmd.Parameters.AddWithValue("IDESTADO", sender.ID_Estado);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarEstadoUser(E_EstadoUsuario sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_ELIMINAR_ESTADOUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("IDESTADO", sender.ID_Estado);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
