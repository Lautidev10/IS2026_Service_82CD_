using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.ComponentModel;

namespace DAL
{
    public class MapperRol_82CD
    {
        private SqlConnection conexion_82CD;

        private void Conectar_82CD()
        {
            conexion_82CD = new Conexion_82CD().ObtenerConexion_82CD();
            conexion_82CD.Open();
        }

        private void Desconectar_82CD()
        {
            if (conexion_82CD != null && conexion_82CD.State == ConnectionState.Open)
                conexion_82CD.Close();
        }

        private Rol_82CD MappearRol(SqlDataReader reader_82CD)
        {
            Rol_82CD rol_82CD = new Rol_82CD();
            rol_82CD.IdRol_82CD = int.Parse(reader_82CD["IDRol_82CD"].ToString());
            rol_82CD.NombreRol_82CD = reader_82CD["Nombre_82CD"].ToString();
            return rol_82CD;
        } 

        //public Rol_82CD BucarPorID_82CD(int IdRol_82CD)
        //{
        //    Rol_82CD rol_82CD;

        //    try
        //    {
        //        Conectar_82CD();
        //        string query_82CD = "SELECT IdRol_82CD, NombreRol_82CD FROM ROL_82CD";
        //        SqlCommand cmd_82CD = new SqlCommand(query_82CD, conexion_82CD);
        //        SqlDataReader reader_82CD = cmd_82CD.ExecuteReader();
        //        while (reader_82CD.Read())
        //        {
        //            li
        //        }
        //}

    }
}
