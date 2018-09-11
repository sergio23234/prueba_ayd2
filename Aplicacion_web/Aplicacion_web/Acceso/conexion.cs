using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion_web
{
    public class conexion
    {
        public Boolean credenciales(String usuario, String password) {
            MySqlConnection conexion = new MySqlConnection("server=35.202.163.254;database=pensum;uid=admin;pwd=1234");
 
            
            try
            {
                conexion.Open();
               

                MySqlCommand comando = new MySqlCommand("select nombre from usuario where usuario = '" + usuario + "' and password = '" + password + "';", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();
                myreader.Read();
                String strnombre = myreader["nombre"].ToString();
                return true;
            }
            catch (Exception ex)
            {

                return false ;
            }
            
        } 

    }
}