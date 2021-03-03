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
    public class D_Rol
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Rol> ListarRoles(string search)
        {
            List<E_Rol> lista = new List<E_Rol>();
            MySqlDataReader leerrows = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VER_ROL", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("BUSCAR", search);
                leerrows = cmd.ExecuteReader();
                while (leerrows.Read())
                {
                    lista.Add(new E_Rol()
                    {
                        ID_Rol = leerrows.GetInt32(0),
                        Rol = leerrows.GetString(1)
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
        public void CrearRol(E_Rol sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_GUARDAR_ROL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("Rol_Name", sender.Rol);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EDITAR_ROL(E_Rol SENDER)
        {
            MySqlCommand cmd = new MySqlCommand("SP_EDITAR_ROL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("Rol_Name", SENDER.Rol);
            cmd.Parameters.AddWithValue("IDROL", SENDER.ID_Rol);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ELIMINAR_ROL(E_Rol SENDER)
        {
            MySqlCommand cmd = new MySqlCommand("SP_ELIMINAR_ROL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();    
            cmd.Parameters.AddWithValue("IDROL", SENDER.ID_Rol);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
