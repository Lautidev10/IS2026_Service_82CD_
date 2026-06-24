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


        public ServicioRol_82CD CargarElementosDelRol_82CD(ServicioRol_82CD Rol_82CD)
        {
          
            // Cada CargarElementosFamilia abre y cierra su propia conexion
            MapperFamilia_82CD mapperFamilia_82CD = new MapperFamilia_82CD();

            foreach (int IdFamilia_82CD in ObtenerIdsFamiliasDelRol_82CD(Rol_82CD.IdRol_82CD))
            {
                ServicioFamilia_82CD familia_82CD = mapperFamilia_82CD.CargarElementosFamilia_82CD(IdFamilia_82CD);
                if (familia_82CD != null)
                    Rol_82CD.AgregarElemento_82CD(familia_82CD);
            }

            foreach (ServicioPermiso_82CD permiso_82CD in ObtenerPermisosDirectosDelRol_82CD(Rol_82CD.IdRol_82CD))
                Rol_82CD.AgregarElemento_82CD(permiso_82CD);

            return Rol_82CD;
        }

        // Devuelve los Ids de las Familias asignadas directamente al rol
        private List<int> ObtenerIdsFamiliasDelRol_82CD(int IdRol_82CD)
        {
            List<int> Ids_82CD = new List<int>();
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT IdFamilia_82CD FROM RolFamilia_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                while (reader_82CD.Read())
                    Ids_82CD.Add(Convert.ToInt32(reader_82CD["IdFamilia_82CD"]));
                reader_82CD.Close();
            }
            finally
            {
                Desconectar_82CD();
            }
            return Ids_82CD;
        }


        // Devuelve los Permisos asignados directamente al rol (sin recorrer familias)
        private List<ServicioPermiso_82CD> ObtenerPermisosDirectosDelRol_82CD(int IdRol_82CD)
        {
            List<ServicioPermiso_82CD> permisos_82CD = new List<ServicioPermiso_82CD>();
            try
            {
                Conectar_82CD();
                string query_82CD = @"SELECT P.IdPermiso_82CD, P.Nombre_82CD, P.Descripcion_82CD FROM Permiso_82CD P 
                    INNER JOIN RolPermiso_82CD RP ON P.IdPermiso_82CD = RP.IdPermiso_82CD 
                    WHERE RP.IdRol_82CD = @IdRol_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                while (reader_82CD.Read())
                {
                    ServicioPermiso_82CD permiso_82CD = new ServicioPermiso_82CD();
                    permiso_82CD.IdPermiso_82CD = Convert.ToInt32(reader_82CD["IdPermiso_82CD"]);
                    permiso_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
                    permiso_82CD.Descripcion_82CD = reader_82CD["Descripcion_82CD"].ToString();
                    permisos_82CD.Add(permiso_82CD);
                }
                reader_82CD.Close();
            }
            finally
            {
                Desconectar_82CD();
            }
            return permisos_82CD;
        }


        public int CrearRol_82CD(ServicioRol_82CD Rol_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = @"INSERT INTO Rol_82CD (NombreRol_82CD) VALUES (@Nombre);
                SELECT CAST(SCOPE_IDENTITY() AS INT)";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre", Rol_82CD.NombreRol_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar());
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void AgregarFamiliasARol_82CD(int IdRol_82CD, List<ServicioFamilia_82CD> Familias_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "INSERT INTO RolFamilia_82CD (IdRol_82CD, IdFamilia_82CD) VALUES (@IdRol_82CD, @IdFamilia_82CD)";
                foreach (ServicioFamilia_82CD familia_82CD in Familias_82CD)
                {
                    SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", familia_82CD.IdFamilia_82CD);
                    cmd_82CD.ExecuteNonQuery();
                }
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        public void AgregarPermisosARol_82CD(int IdRol_82CD, List<ServicioPermiso_82CD> Permisos_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "INSERT INTO RolPermiso_82CD (IdRol_82CD, IdPermiso_82CD) VALUES (@IdRol_82CD, @IdPermiso_82CD)";
                foreach (ServicioPermiso_82CD permiso_82CD in Permisos_82CD)
                {
                    SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdPermiso_82CD", permiso_82CD.IdPermiso_82CD);
                    cmd_82CD.ExecuteNonQuery();
                }
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        public void EliminarRol_82CD(int IdRol_82CD)
        {
            try
            {
                Conectar_82CD();

                string queryRF_82CD = "DELETE FROM RolFamilia_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmdRF_82CD = new SqlCommand(queryRF_82CD, conexion_82CD);
                cmdRF_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                cmdRF_82CD.ExecuteNonQuery();

                string queryRP_82CD = "DELETE FROM RolPermiso_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmdRP_82CD = new SqlCommand(queryRP_82CD, conexion_82CD);
                cmdRP_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                cmdRP_82CD.ExecuteNonQuery();

                string queryR_82CD = "DELETE FROM Rol_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmdR_82CD = new SqlCommand(queryR_82CD, conexion_82CD);
                cmdR_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                cmdR_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        public bool ExisteRol_82CD(string Nombre_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT COUNT(*) FROM Rol_82CD WHERE NombreRol_82CD = @Nombre_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre_82CD", Nombre_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        // No permitir eliminar un rol si lo usa algún usuario (activo o inactivo)
        public bool RolEstaEnUsuario_82CD(int IdRol_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT COUNT(*) FROM Usuario_82CD WHERE IdRol_82CD = @IdRol_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdRol_82CD", IdRol_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void CrearRolesBase_82CD()
        {
            try
            {
                Conectar_82CD();
                string query_82CD = @"
                IF NOT EXISTS (SELECT 1 FROM Rol_82CD WHERE NombreRol_82CD = 'Administrador')
                BEGIN
                    INSERT INTO Rol_82CD (NombreRol_82CD)
                    VALUES ('Administrador')
                END

                IF NOT EXISTS (SELECT 1 FROM Rol_82CD WHERE NombreRol_82CD = 'Cliente')
                BEGIN
                    INSERT INTO Rol_82CD (NombreRol_82CD)
                    VALUES ('Cliente')
                END";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }
    }
}
