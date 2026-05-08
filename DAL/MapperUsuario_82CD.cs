using BE;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MapperUsuario_82CD
    {
        private SqlConnection conexion_82CD;

        private void Conectar_82CD()
        {
            Conexion_82CD cn_82CD = new Conexion_82CD();
            conexion_82CD = cn_82CD.ObtenerConexion_82CD();

            conexion_82CD.Open();
        }

        private void Desconectar_82CD()
        {
            if(conexion_82CD != null && conexion_82CD.State == ConnectionState.Open)
            {
                conexion_82CD.Close();
            }
        }

        private UsuarioBE_82CD MapearUsuario_82CD(SqlDataReader reader_82CD)
        {
            UsuarioBE_82CD usuariobe_82CD = new UsuarioBE_82CD();

            usuariobe_82CD.DNI_82CD = reader_82CD["DNI_82CD"].ToString();
            usuariobe_82CD.Apellidos_82CD = reader_82CD["Apellidos_82CD"].ToString();
            usuariobe_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
            usuariobe_82CD.Email_82CD = reader_82CD["Email_82CD"].ToString();
            usuariobe_82CD.LogIn_82CD = reader_82CD["LogIn_82CD"].ToString() ;
            usuariobe_82CD.Password_82CD = reader_82CD["Password_82CD"].ToString();
            usuariobe_82CD.IdRol_82CD = Convert.ToInt32(reader_82CD["IdRol_82CD"]);
            usuariobe_82CD.Bloqueado_82CD = Convert.ToBoolean(reader_82CD["Bloqueado_82CD"]);
            usuariobe_82CD.Activo_82CD = Convert.ToBoolean(reader_82CD["Activo_82CD"]);

            return usuariobe_82CD;
        }

        public List<UsuarioBE_82CD> ListarUsuario_82CD(bool soloActivos_82CD)
        {
            List<UsuarioBE_82CD> ls_82CD = new List<UsuarioBE_82CD>();

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT U.DNI_82CD, U.Apellidos_82CD, U.Nombre_82CD, U.Email_82CD, U.LogIn_82CD, U.Password_82CD, U.IdRol_82CD, U.Bloqueado_82CD, U.Activo_82CD FROM Usuario_82CD U";
                if (soloActivos_82CD)
                    query_82CD += " WHERE U.Activo_82CD = 1";
                query_82CD += " ORDER BY U.Apellidos_82CD, U.Nombre_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                while (reader_82CD.Read())
                {
                    ls_82CD.Add(MapearUsuario_82CD(reader_82CD));
                }
            }
            finally
            {
                Desconectar_82CD();
            }

            return ls_82CD;
        }
    }
}
