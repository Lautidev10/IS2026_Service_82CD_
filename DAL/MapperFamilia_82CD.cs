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
    public class MapperFamilia_82CD
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


        public List<ServicioFamilia_82CD> ListarFamilias_82CD()
        {
            List<ServicioFamilia_82CD> lista_82CD = new List<ServicioFamilia_82CD>();

            try
            {
                Conectar_82CD();

                string query_82CD = "SELECT IdFamilia_82CD, Nombre_82CD FROM Familia_82CD ORDER BY Nombre_82CD";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                while (reader_82CD.Read())
                {
                    ServicioFamilia_82CD familia_82CD = new ServicioFamilia_82CD();
                    familia_82CD.IdFamilia_82CD = Convert.ToInt32(reader_82CD["IdFamilia_82CD"]);
                    familia_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
                    lista_82CD.Add(familia_82CD);
                }
                reader_82CD.Close();
            }
            finally
            {
                Desconectar_82CD();
            }

            return lista_82CD;
        }


        //Estructura recursiva para reconstruir las relaciones entre familias desde la BD.

        //ABM FAMILIAS

        //AgregarPermisosaFamilia
        //AgregarFamiliasaFamilia

        //Validaciones para que los permisos no se pisen y que no se puedan eliminar familias que sean utilizadas por un usuario mediante rol


    }
}
