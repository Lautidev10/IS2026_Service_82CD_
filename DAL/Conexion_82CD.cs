using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion_82CD
    {
        private string cadena_82CD = "Data Source=DESKTOP-KOJQQSA;Initial Catalog=IS2026_82CD;Integrated Security=True";

        public SqlConnection ObtenerConexion_82CD()
        {
            SqlConnection conexion_82CD = new SqlConnection(cadena_82CD);
            return conexion_82CD;
        }
    }
}
