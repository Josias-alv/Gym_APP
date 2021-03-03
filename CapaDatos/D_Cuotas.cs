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
    public class D_Cuotas
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Cuotas> listarcuotas()
        {
            List<E_Cuotas> lista = new List<E_Cuotas>();
            MySqlDataReader leerrows = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VER_CUOTAS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                leerrows = cmd.ExecuteReader();
                while (leerrows.Read())
                {
                    lista.Add(new E_Cuotas()
                    {
                        ID_Cuota = leerrows.GetInt32(0),
                        Cuota = leerrows.GetDecimal(1)
                    });
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    leerrows.Close();
                }
            }
            return lista;
            
        }
        public void CrearCuota(E_Cuotas sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_GUARDAR_CUOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("CUOTA", sender.Cuota);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EDITAR_CUOTA(E_Cuotas SENDER)
        {
            MySqlCommand cmd = new MySqlCommand("SP_EDITAR_CUOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("CUOTA", SENDER.Cuota);
            cmd.Parameters.AddWithValue("IDCUOTA", SENDER.ID_Cuota);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ELIMINAR_CUOTA(E_Cuotas sender)
        {
            MySqlCommand cmd = new MySqlCommand("SP_ELIMINAR_CUOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("IDCUOTA", sender.ID_Cuota);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
