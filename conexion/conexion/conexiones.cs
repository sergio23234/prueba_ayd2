using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    public class conexiones
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=35.202.163.254;database=pensum;uid=admin;pwd=1234");
            conexion.Open();
            return conexion;
        }
    }
}
