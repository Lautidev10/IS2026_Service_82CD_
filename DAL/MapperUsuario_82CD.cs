using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MapperUsuario_82CD
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
            usuariobe_82CD.LogIn_82CD = reader_82CD["LogIn_82CD"].ToString();
            usuariobe_82CD.Password_82CD = reader_82CD["Password_82CD"].ToString();
            usuariobe_82CD.IdRol_82CD = int.Parse(reader_82CD["IdRol_82CD"].ToString());
            usuariobe_82CD.Bloqueado_82CD = Convert.ToBoolean(reader_82CD["Bloqueado_82CD"].ToString());
            usuariobe_82CD.Activo_82CD = Convert.ToBoolean(reader_82CD["Activo_82CD"].ToString());

            return usuariobe_82CD;
        }

        public List<UsuarioBE_82CD> ListarUsuario_82CD(bool estado_82CD)
        {
            List<UsuarioBE_82CD> ls_82CD = new List<UsuarioBE_82CD>();

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT U.DNI_82CD, U.Apellidos_82CD, U.Nombre_82CD, U.Email_82CD, U.LogIn_82CD, U.Password_82CD, U.IdRol_82CD, U.Bloqueado_82CD, U.Activo_82CD FROM Usuario_82CD U";
                if (estado_82CD)
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

        public void AgregarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "INSERT INTO Usuario_82CD (DNI_82CD, Apellidos_82CD, Nombre_82CD, Email_82CD, [LogIn_82CD], [Password_82CD], IdRol_82CD, Bloqueado_82CD, Activo_82CD) VALUES (@DNI_82CD, @Apellidos_82CD, @Nombre_82CD, @Email_82CD, @LogIn_82CD, @Password_82CD, @IdRol_82CD, @Bloqueado_82CD, @Activo_82CD)";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", usuario_82CD.DNI_82CD);
                cmd_82CD.Parameters.AddWithValue("@Apellidos_82CD", usuario_82CD.Apellidos_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre_82CD", usuario_82CD.Nombre_82CD);
                cmd_82CD.Parameters.AddWithValue("@Email_82CD", usuario_82CD.Email_82CD);
                cmd_82CD.Parameters.AddWithValue("@LogIn_82CD", usuario_82CD.LogIn_82CD);
                cmd_82CD.Parameters.AddWithValue("@Password_82CD", usuario_82CD.Password_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", usuario_82CD.IdRol_82CD);
                cmd_82CD.Parameters.AddWithValue("@Bloqueado_82CD", usuario_82CD.Bloqueado_82CD);
                cmd_82CD.Parameters.AddWithValue("@Activo_82CD", usuario_82CD.Activo_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void ModificarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "UPDATE Usuario_82CD SET Apellidos_82CD = @Apellidos_82CD, Nombre_82CD = @Nombre_82CD, Email_82CD = @Email_82CD, IdRol_82CD = @IdRol_82CD WHERE DNI_82CD = @DNI_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", usuario_82CD.DNI_82CD);
                cmd_82CD.Parameters.AddWithValue("@Apellidos_82CD", usuario_82CD.Apellidos_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre_82CD", usuario_82CD.Nombre_82CD);
                cmd_82CD.Parameters.AddWithValue("@Email_82CD", usuario_82CD.Email_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", usuario_82CD.IdRol_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void CambiarEstadoUsuario_82CD(UsuarioBE_82CD usuario_82CD, bool estado_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "UPDATE Usuario_82CD SET Activo_82CD = @Activo_82CD WHERE DNI_82CD = @DNI_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", usuario_82CD.DNI_82CD);
                cmd_82CD.Parameters.AddWithValue("@Activo_82CD", estado_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void DesbloquearUsuario_82CD(string dni_82CD, string passwordIni_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "UPDATE Usuario_82CD SET Bloqueado_82CD = 0, [Password_82CD] = @Password_82CD WHERE DNI_82CD = @DNI_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", dni_82CD);
                cmd_82CD.Parameters.AddWithValue("@Password_82CD", passwordIni_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void ActualizarContraseña_82CD(string dni_82CD, string passwordEncrip_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "UPDATE Usuario_82CD SET [Password_82CD] = @Password_82CD WHERE DNI_82CD = @DNI_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", dni_82CD);
                cmd_82CD.Parameters.AddWithValue("@Password_82CD", passwordEncrip_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        public UsuarioBE_82CD BuscarUsuarioPorLogIn_82CD(string login_82CD)
        {
            UsuarioBE_82CD usuario_82CD = null;
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT DNI_82CD, Apellidos_82CD, Nombre_82CD, Email_82CD, LogIn_82CD, Password_82CD, IdRol_82CD, Bloqueado_82CD, Activo_82CD FROM Usuario_82CD WHERE LogIn_82CD = @LogIn_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@LogIn_82CD", login_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                if (reader_82CD.Read())
                {
                    usuario_82CD = MapearUsuario_82CD(reader_82CD);
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return usuario_82CD;
        }

        public UsuarioBE_82CD BuscarUsuarioPorDNI_82CD(string dni_82CD /*string password_82CD*/)
        {
            UsuarioBE_82CD usuario_82CD = null;
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT DNI_82CD, Apellidos_82CD, Nombre_82CD, Email_82CD, [LogIn_82CD], [Password_82CD], IdRol_82CD, Bloqueado_82CD, Activo_82CD FROM Usuario_82CD WHERE DNI_82CD = @DNI_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@DNI_82CD", dni_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                if (reader_82CD.Read())
                {
                    usuario_82CD = MapearUsuario_82CD(reader_82CD);
                }
            }
            finally
            {
                Desconectar_82CD();
            }

            return usuario_82CD;
        }

        public void BloquearUsuario_82CD(string login_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "UPDATE Usuario_82CD SET Bloqueado_82CD = 1 WHERE LogIn_82CD = @LogIn_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@LogIn_82CD", login_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }




    }
}
