using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Servicio;

namespace DAL
{
    public class MapperRol_82CD
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

        private ServicioRol_82CD MappearRol_82CD(SqlDataReader reader_82CD)
        {
            ServicioRol_82CD rol_82CD = new ServicioRol_82CD();
            rol_82CD.IdRol_82CD = int.Parse(reader_82CD["IdRol_82CD"].ToString());
            rol_82CD.NombreRol_82CD = reader_82CD["NombreRol_82CD"].ToString();
            return rol_82CD;
        }

        public ServicioRol_82CD BucarRolPorID_82CD(int IdRol_82CD)
        {
            ServicioRol_82CD rol_82CD = null;

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT IdRol_82CD, NombreRol_82CD FROM Rol_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                if (reader_82CD.Read())
                {
                    rol_82CD = MappearRol_82CD(reader_82CD);
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return rol_82CD;
        }

        public List<ServicioRol_82CD> ObtenerRoles_82CD()
        {
            List<ServicioRol_82CD> lista_82CD = new List<ServicioRol_82CD>();

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT IdRol_82CD, NombreRol_82CD FROM Rol_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                while (reader_82CD.Read())
                {
                    lista_82CD.Add(MappearRol_82CD(reader_82CD));
                }
            }
            finally
            {
                Desconectar_82CD();
            }

            return lista_82CD;
        }


        //ABM ROLES

        //Estructura recursiva para reconstruir los permisos que deberia tener un rol desde la BD.

        //Asociar los permisos y familias que tiene rol reconstruyendolo desde la BD

        //Validaciones, no permitir que un rol se elimine si es utilizado por algun usuario del sistema (tanto activos como inactivos).

    }
}
