using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace Aplicacion_web
{
    public partial class busqueda : System.Web.UI.Page
    {
        

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Logica.peticion.Responder_Peticion_de_cursos(ref dgv1, txtConsulta.Text);

        }
    }
}