using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MapperEvento_82CD
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


        public void RegistrarEvento_82CD(string login_82CD, string evento_82CD, string modulo_82CD, int criticidad_82CD)
        {
            try
            {
                Conectar_82CD();
                string query_82CD = "INSERT INTO Eventos_82CD (LogIn_82CD, Fecha_82CD, Hora_82CD, Modulo_82CD, Evento_82CD, Criticidad_82CD) VALUES (@Login, CAST (GETDATE() AS DATE), CAST (GETDATE() AS TIME), @Modulo, @Evento, @Criticidad)";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);

                cmd_82CD.Parameters.AddWithValue("@Login", login_82CD);
                cmd_82CD.Parameters.AddWithValue("@Evento", evento_82CD);
                cmd_82CD.Parameters.AddWithValue("@Modulo", modulo_82CD);
                cmd_82CD.Parameters.AddWithValue("@Criticidad", criticidad_82CD);

                cmd_82CD.ExecuteNonQuery();
            }
            finally
            {
                Desconectar_82CD();
            }
        }

        public List<ServicioEvento_82CD> ListarEventos_82CD()
        {
            List<ServicioEvento_82CD> listaEventos_82CD = new List<ServicioEvento_82CD>();

            try
            {
                Conectar_82CD();
                string query_82CD = "SELECT * FROM Eventos_82CD ORDER BY Fecha_82CD DESC, Hora_82CD DESC";
                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                while (reader_82CD.Read())
                {
                    listaEventos_82CD.Add(new ServicioEvento_82CD
                    {
                        LogIn_82CD = reader_82CD["LogIn_82CD"].ToString(),
                        Fecha_82CD = Convert.ToDateTime(reader_82CD["Fecha_82CD"]),
                        Hora_82CD = Convert.ToDateTime(reader_82CD["Hora_82CD"]),
                        Modulo_82CD = reader_82CD["Modulo_82CD"].ToString(),
                        IDEvento_82CD = Convert.ToInt32(reader_82CD["IdEvento_82CD"]),
                        Evento_82CD = reader_82CD["Evento_82CD"].ToString(),
                        Criticidad_82CD = Convert.ToInt32(reader_82CD["Calificacion_82CD"])
                    });
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return listaEventos_82CD;
        }

        public List<ServicioEvento_82CD> ObtenerEventosUlt3Dias_82CD()
        {
            List<ServicioEvento_82CD> listaEventos_82CD = new List<ServicioEvento_82CD>();

            try
            {
                Conectar_82CD();
                string query_82CD = @"SELECT * FROM Eventos_82CD 
                              WHERE Fecha_82CD >= CAST (DATEADD (DAY, -3, GETDATE()) AS DATE)
                              ORDER BY Fecha_82CD ASC, Hora_82CD ASC";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                while (reader_82CD.Read())
                {
                    listaEventos_82CD.Add(new ServicioEvento_82CD
                    {
                        LogIn_82CD = reader_82CD["LogIn_82CD"].ToString(),
                        Fecha_82CD = Convert.ToDateTime(reader_82CD["Fecha_82CD"]),
                        Hora_82CD = Convert.ToDateTime(reader_82CD["Hora_82CD"]),
                        Modulo_82CD = reader_82CD["Modulo_82CD"].ToString(),
                        IDEvento_82CD = Convert.ToInt32(reader_82CD["IdEvento_82CD"]),
                        Evento_82CD = reader_82CD["Evento_82CD"].ToString(),
                        Criticidad_82CD = Convert.ToInt32(reader_82CD["Calificacion_82CD"])
                    });
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return listaEventos_82CD;
        }


    }
}
