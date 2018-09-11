using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Aplicacion_web.Acceso
{
    public class Seleccion
    {
        public static DataSet GetCursosBuscados(String busqueda)
        {
            MySqlConnection conexion = new MySqlConnection("server=35.202.163.254;database=pensum;uid=admin;pwd=1234");
            try
            {
                conexion.Open();
                String consulta = "select codigo, nombre, area_codigo from curso where nombre LIKE '%" + busqueda + "%';";
                MySqlCommand cm = new MySqlCommand(consulta, conexion);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                da.Fill(ds);
                conexion.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}