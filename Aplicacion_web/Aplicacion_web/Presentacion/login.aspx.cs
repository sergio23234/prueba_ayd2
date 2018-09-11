using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion_web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String usuario=txtUsuario.Text;
            String password = txtPassword.Text;
            conexion cn = new conexion();

            if (cn.credenciales(usuario, password)) {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Credenciales correctas')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Credenciales incorrectas')</script>");
            }


        }
    }
}