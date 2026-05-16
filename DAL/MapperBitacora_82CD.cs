using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MapperBitacora_82CD
    {
        private SqlConnection conexion_82CD;

        private void Conectar_82CD()
        {
            conexion_82CD = Conexion_82CD.ObtenerConexion_82CD();
            conexion_82CD.Open();
        }

        private void Desconectar_82CD()
        {
            if (conexion_82CD != null && conexion_82CD.State == ConnectionState.Open)
                conexion_82CD.Close();
        }


        public void RegistrarEvento_82CD(string evento_82CD, string login_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "INSERT INTO Bitacora_82CD (Evento_82CD, LogIn_82CD, Fecha_82CD) VALUES (@Evento, @Login, GETDATE())";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);

                cmd_82CD.Parameters.AddWithValue("@Evento", evento_82CD);
                cmd_82CD.Parameters.AddWithValue("@Login", login_82CD);

                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }


    }
}
