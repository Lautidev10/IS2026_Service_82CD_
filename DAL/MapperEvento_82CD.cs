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

        public ServicioEvento_82CD MappearEvento_82CD(SqlDataReader reader_82CD)
        {
            ServicioEvento_82CD evento_82CD = new ServicioEvento_82CD();

            evento_82CD.IDEvento_82CD = Convert.ToInt32(reader_82CD["Id_Evento_82CD"]);
            evento_82CD.LogIn_82CD = reader_82CD["LogIn_82CD"].ToString();
            evento_82CD.Fecha_82CD = Convert.ToDateTime(reader_82CD["Fecha_82CD"]);
            evento_82CD.Hora_82CD = (TimeSpan)reader_82CD["Hora_82CD"];
            evento_82CD.Modulo_82CD = reader_82CD["Modulo_82CD"].ToString();
            evento_82CD.Evento_82CD = reader_82CD["Evento_82CD"].ToString();
            evento_82CD.Criticidad_82CD = Convert.ToInt32(reader_82CD["Criticidad_82CD"]);

            return evento_82CD;
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
                        IDEvento_82CD = Convert.ToInt32(reader_82CD["Id_Evento_82CD"]),
                        LogIn_82CD = reader_82CD["LogIn_82CD"].ToString(),
                        Fecha_82CD = Convert.ToDateTime(reader_82CD["Fecha_82CD"]),
                        Hora_82CD = (TimeSpan)reader_82CD["Hora_82CD"],
                        Modulo_82CD = reader_82CD["Modulo_82CD"].ToString(),
                        Evento_82CD = reader_82CD["Evento_82CD"].ToString(),
                        Criticidad_82CD = Convert.ToInt32(reader_82CD["Criticidad_82CD"])
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
                        IDEvento_82CD = Convert.ToInt32(reader_82CD["Id_Evento_82CD"]),
                        LogIn_82CD = reader_82CD["LogIn_82CD"].ToString(),
                        Fecha_82CD = Convert.ToDateTime(reader_82CD["Fecha_82CD"]),
                        Hora_82CD = (TimeSpan)reader_82CD["Hora_82CD"],
                        Modulo_82CD = reader_82CD["Modulo_82CD"].ToString(),
                        Evento_82CD = reader_82CD["Evento_82CD"].ToString(),
                        Criticidad_82CD = Convert.ToInt32(reader_82CD["Criticidad_82CD"])
                    });
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return listaEventos_82CD;
        }

        public ServicioUsuario_82CD BuscarUsuarioEvento_82CD(string login_82CD)
        {
            ServicioUsuario_82CD usuario_82CD = null;
            try
            {
                Conectar_82CD();
                string query_82CD = @"SELECT Nombre_82CD, Apellidos_82CD 
                              FROM Usuario_82CD 
                              WHERE LogIn_82CD = @LogIn";

                SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
                cmd_82CD.Parameters.AddWithValue("@LogIn", login_82CD);
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();

                if (reader_82CD.Read())
                {
                    usuario_82CD = new ServicioUsuario_82CD();
                    usuario_82CD.Nombre_82CD = reader_82CD["Nombre_82CD"].ToString();
                    usuario_82CD.Apellidos_82CD = reader_82CD["Apellidos_82CD"].ToString();
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return usuario_82CD;
        }

        public List<ServicioEvento_82CD> FiltrarEventos_82CD(string login_82CD, DateTime fechaInicial_82CD, DateTime fechaFinal_82CD, string evento_82CD, string modulo_82CD, int criticidad_82CD)
        {
            List<ServicioEvento_82CD> eventosFiltrados_82CD = new List<ServicioEvento_82CD>();
            try
            {
                Conectar_82CD();
                string query_82CD = @"SELECT * FROM Eventos_82CD
                              WHERE Fecha_82CD BETWEEN @FechaInicial_82CD AND @FechaFinal_82CD";
                
                SqlCommand cmd_82CD = new SqlCommand();
                cmd_82CD.Connection = conexion_82CD;
                
                cmd_82CD.Parameters.AddWithValue("@FechaInicial_82CD", fechaInicial_82CD);
                cmd_82CD.Parameters.AddWithValue("@FechaFinal_82CD", fechaFinal_82CD);
                
                if(login_82CD != null)
                {
                    query_82CD += " AND LogIn_82CD = @LogIn_82CD";
                    cmd_82CD.Parameters.AddWithValue("@LogIn_82CD", login_82CD);
                }

                if (evento_82CD != null)
                {
                    query_82CD += " AND Evento_82CD = @Evento_82CD";
                    cmd_82CD.Parameters.AddWithValue("@Evento_82CD", evento_82CD);
                }

                if(modulo_82CD != null)
                {
                    query_82CD += " AND Modulo_82CD = @Modulo_82CD";
                    cmd_82CD.Parameters.AddWithValue("@Modulo_82CD", modulo_82CD);
                }

                if (criticidad_82CD != -1)
                {
                    query_82CD += " AND Criticidad_82CD = @Criticidad_82CD";
                    cmd_82CD.Parameters.AddWithValue("@Criticidad_82CD", criticidad_82CD);
                }

                query_82CD += " ORDER BY Fecha_82CD DESC, Hora_82CD DESC";
                
                cmd_82CD.CommandText = query_82CD;
                SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
                while (reader_82CD.Read())
                {
                    eventosFiltrados_82CD.Add(MappearEvento_82CD(reader_82CD));
                }
            }
            finally
            {
                Desconectar_82CD();
            }
            return eventosFiltrados_82CD;
        }

    }
}
