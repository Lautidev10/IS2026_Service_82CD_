using Servicio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Http.Headers;

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

        private ServicioFamilia_82CD MappearFamilia_82CD(SqlDataReader reader_82CD)
        {
            ServicioFamilia_82CD familia_82CD = new ServicioFamilia_82CD();
            familia_82CD.IdFamilia_82CD = Convert.ToInt32(reader_82CD["IdFamilia_82CD"]);
            familia_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
            return familia_82CD;
        }


        public ServicioFamilia_82CD BuscarFamiliaPorID_82CD(int IdFamilia_82CD)
        {
            ServicioFamilia_82CD familia_82CD = null;

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT IdFamilia_82CD, Nombre_82CD FROM Familia_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                if (reader_82CD.Read())
                {
                    familia_82CD = MappearFamilia_82CD(reader_82CD);
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return familia_82CD;
        }


        //Llama a la estructura recursiva para reconstruir las relaciones de la familia desde la BD
        public ServicioFamilia_82CD CargarElementosFamilia_82CD(int IdFamilia_82CD)
        {
            try
            {
                Conectar_82CD();
                return CargarFamiliaRecursivo_82CD(IdFamilia_82CD);
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        // Construye el arbol con la conexion ya abierta, carga los datos de una familia agregandole sus Permisos directos y cada sub-Familia llamandose a si misma

        private ServicioFamilia_82CD CargarFamiliaRecursivo_82CD(int IdFamilia_82CD)
        {
            ServicioFamilia_82CD familia_82CD = null;

            string queryFam_82CD = "SELECT IdFamilia_82CD, Nombre_82CD FROM Familia_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD";
            SqlCommand cmdFam_82CD = new SqlCommand(queryFam_82CD, conexion_82CD);
            cmdFam_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
            SqlDataReader readerFam_82CD = cmdFam_82CD.ExecuteReader();

            if (readerFam_82CD.Read())
            {
                familia_82CD = new ServicioFamilia_82CD();
                familia_82CD.IdFamilia_82CD = Convert.ToInt32(readerFam_82CD["IdFamilia_82CD"]);
                familia_82CD.Nombre_82CD = readerFam_82CD["Nombre_82CD"].ToString();
            }
            readerFam_82CD.Close();

            if (familia_82CD == null)
                return null;

            // Permisos directos de esta Familia
            string queryPermisos_82CD = @"SELECT P.IdPermiso_82CD, P.Nombre_82CD, P.Descripcion_82CD FROM Permiso_82CD P
            INNER JOIN FamiliaPermiso_82CD FP ON P.IdPermiso_82CD = FP.IdPermiso_82CD WHERE FP.IdFamilia_82CD = @IdFamilia_82CD;";

            SqlCommand cmdPermisos_82CD = new SqlCommand(queryPermisos_82CD, conexion_82CD);
            cmdPermisos_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
            SqlDataReader readerPermisos_82CD = cmdPermisos_82CD.ExecuteReader();

            while (readerPermisos_82CD.Read())
            {
                ServicioPermiso_82CD permiso_82CD = new ServicioPermiso_82CD();
                permiso_82CD.IdPermiso_82CD = Convert.ToInt32(readerPermisos_82CD["IdPermiso_82CD"]);
                permiso_82CD.Nombre_82CD = readerPermisos_82CD["Nombre_82CD"].ToString();
                permiso_82CD.Descripcion_82CD = readerPermisos_82CD["Descripcion_82CD"].ToString();
                familia_82CD.AgregarElemento_82CD(permiso_82CD);
            }
            readerPermisos_82CD.Close();

            // Lista que guarda los IDs de las sub-Familias, luego se cierra el reader antes de recursar porque SQL no permite dos readers abiertos a la vez
            
            List<int> IdsHijas_82CD = new List<int>();

            string queryHijas_82CD = "SELECT IdFamiliaHija_82CD FROM FamiliaFamilia_82CD WHERE IdFamiliaPadre_82CD = @IdPadre_82CD";
            SqlCommand cmdHijas_82CD = new SqlCommand(queryHijas_82CD, conexion_82CD);
            cmdHijas_82CD.Parameters.AddWithValue("@IdPadre_82CD", IdFamilia_82CD);
            SqlDataReader readerHijas_82CD = cmdHijas_82CD.ExecuteReader();

            while (readerHijas_82CD.Read())
            {
                IdsHijas_82CD.Add(Convert.ToInt32(readerHijas_82CD["IdFamiliaHija_82CD"]));
            }
            readerHijas_82CD.Close();

            // Cargar cada sub-Familia recursivamente
            foreach (int IdHija_82CD in IdsHijas_82CD)
            {
                ServicioFamilia_82CD hija_82CD = CargarFamiliaRecursivo_82CD(IdHija_82CD);
                if (hija_82CD != null)
                    familia_82CD.AgregarElemento_82CD(hija_82CD);
            }

            return familia_82CD;
        }

        //Devuelve int para tener el idfamilia y crearla con los permisos asignados
        public int CrearFamilia_82CD(ServicioFamilia_82CD Familia_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = "INSERT INTO Familia_82CD (Nombre_82CD) VALUES (@Nombre_82CD); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre_82CD", Familia_82CD.Nombre_82CD);

                return Convert.ToInt32(cmd_82CD.ExecuteScalar());
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        
        //AgregaPermisosAFamilia
        public void AgregarPermisosAFamilia_82CD(int IdFamilia_82CD, List<ServicioPermiso_82CD> Permisos_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = "INSERT INTO FamiliaPermiso_82CD (IdFamilia_82CD, IdPermiso_82CD) VALUES (@IdFamilia_82CD, @IdPermiso_82CD)";

                foreach (ServicioPermiso_82CD Permiso_82CD in Permisos_82CD)
                {
                    SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdPermiso_82CD", Permiso_82CD.IdPermiso_82CD);
                    cmd_82CD.ExecuteNonQuery();
                }
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        //AgregaFamiliasAFamilia
        public void AgregarFamiliasAFamilia_82CD(int IdFamiliaPadre_82CD, List<ServicioFamilia_82CD> Hijas_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = "INSERT INTO FamiliaFamilia_82CD (IdFamiliaPadre_82CD, IdFamiliaHija_82CD) VALUES (@IdPadre_82CD, @IdHija_82CD)";

                foreach (ServicioFamilia_82CD Hija_82CD in Hijas_82CD)
                {
                    SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdPadre_82CD", IdFamiliaPadre_82CD);
                    cmd_82CD.Parameters.AddWithValue("@IdHija_82CD", Hija_82CD.IdFamilia_82CD);
                    cmd_82CD.ExecuteNonQuery();
                }
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        // Elimina la Familia y sus relaciones, tiene una validacion antes que no permite que pertenezca a otra Familia ni este asignada a un rol
        public void EliminarFamilia_82CD(int IdFamilia_82CD)
        {
            try
            {
                Conectar_82CD();

                string queryFP_82CD = "DELETE FROM FamiliaPermiso_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD";
                SqlCommand cmdFP_82CD = new SqlCommand(queryFP_82CD, conexion_82CD);
                cmdFP_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                cmdFP_82CD.ExecuteNonQuery();

                string queryFF_82CD = "DELETE FROM FamiliaFamilia_82CD WHERE IdFamiliaPadre_82CD = @IdFamilia_82CD OR IdFamiliaHija_82CD = @IdFamilia_82CD";
                SqlCommand cmdFF_82CD = new SqlCommand(queryFF_82CD, conexion_82CD);
                cmdFF_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                cmdFF_82CD.ExecuteNonQuery();

                string queryF_82CD = "DELETE FROM Familia_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD";
                SqlCommand cmdF_82CD = new SqlCommand(queryF_82CD, conexion_82CD);
                cmdF_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                cmdF_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        
        //Validaciones para que los permisos no se pisen y que no se puedan eliminar familias que sean utilizadas por un usuario mediante rol
        public bool ExisteFamilia_82CD(string Nombre_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT COUNT(*) FROM Familia_82CD WHERE Nombre_82CD = @Nombre_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@Nombre_82CD", Nombre_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        // Retorna true si la Familia es hija de alguna otra Familia
        public bool FamiliaExisteEnOtraFamilia_82CD(int IdFamilia_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT COUNT(*) FROM FamiliaFamilia_82CD WHERE IdFamiliaHija_82CD = @IdFamilia_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        // Retorna true si la Familia esta asignada a algun Rol
        public bool FamiliaExisteEnOtroRol_82CD(int IdFamilia_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT COUNT(*) FROM RolFamilia_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", IdFamilia_82CD);
                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }


        public bool FamiliaTienePermiso_82CD(int idFamilia_82CD, int idPermiso_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = @"SELECT COUNT(*) FROM FamiliaPermiso_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD AND IdPermiso_82CD = @IdPermiso_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", idFamilia_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdPermiso_82CD", idPermiso_82CD);

                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void AgregarPermisoAFamilia_82CD(int idFamilia_82CD, int idPermiso_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = @"INSERT INTO FamiliaPermiso_82CD (IdFamilia_82CD, IdPermiso_82CD) VALUES (@IdFamilia_82CD, @IdPermiso_82CD)";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", idFamilia_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdPermiso_82CD", idPermiso_82CD);

                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void QuitarPermisoAFamilia_82CD(int idFamilia_82CD, int idPermiso_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = @"DELETE FROM FamiliaPermiso_82CD WHERE IdFamilia_82CD = @IdFamilia_82CD AND IdPermiso_82CD = @IdPermiso_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamilia_82CD", idFamilia_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdPermiso_82CD", idPermiso_82CD);

                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public bool FamiliaTieneSubfamilia_82CD(int idFamiliaPadre_82CD, int idFamiliaHija_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = @"SELECT COUNT(*) FROM FamiliaFamilia_82CD WHERE IdFamiliaPadre_82CD = @IdFamiliaPadre_82CD AND IdFamiliaHija_82CD = @IdFamiliaHija_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaPadre_82CD", idFamiliaPadre_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaHija_82CD", idFamiliaHija_82CD);

                return Convert.ToInt32(cmd_82CD.ExecuteScalar()) > 0;
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void AgregarSubfamiliaAFamilia_82CD(int idFamiliaPadre_82CD, int idFamiliaHija_82CD)
        {
            try
            {
                Conectar_82CD();

                string query_82CD = @"INSERT INTO FamiliaFamilia_82CD (IdFamiliaPadre_82CD, IdFamiliaHija_82CD) VALUES (@IdFamiliaPadre_82CD, @IdFamiliaHija_82CD)";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaPadre_82CD", idFamiliaPadre_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaHija_82CD", idFamiliaHija_82CD);

                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public void QuitarSubfamiliaAFamilia_82CD(int idFamiliaPadre_82CD, int idFamiliaHija_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = @"DELETE FROM FamiliaFamilia_82CD WHERE IdFamiliaPadre_82CD = @IdFamiliaPadre_82CD AND IdFamiliaHija_82CD = @IdFamiliaHija_82CD";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaPadre_82CD", idFamiliaPadre_82CD);
                cmd_82CD.Parameters.AddWithValue("@IdFamiliaHija_82CD", idFamiliaHija_82CD);
                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

    }
}