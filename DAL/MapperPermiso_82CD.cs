using Servicio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MapperPermiso_82CD
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

        public List<ServicioPermiso_82CD> ListarPermisos_82CD()
        {
            List<ServicioPermiso_82CD> lista_82CD = new List<ServicioPermiso_82CD>();

            try
            {
                Conectar_82CD();

                string query_82CD = "SELECT IdPermiso_82CD, Nombre_82CD, Descripcion_82CD FROM Permiso_82CD ORDER BY Nombre_82CD";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                while (reader_82CD.Read())
                {
                    ServicioPermiso_82CD permiso_82CD = new ServicioPermiso_82CD();
                    permiso_82CD.IdPermiso_82CD = Convert.ToInt32(reader_82CD["IdPermiso_82CD"]);
                    permiso_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
                    permiso_82CD.Descripcion_82CD = reader_82CD["Descripcion_82CD"].ToString();
                    lista_82CD.Add(permiso_82CD);
                }

                reader_82CD.Close();
            }
            finally
            {
                Desconectar_82CD();
            }

            return lista_82CD;
        }




    }
}
