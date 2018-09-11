
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Aplicacion_web.Logica
{
    public class peticion
    {
        public static void Responder_Peticion_de_cursos(ref GridView dgw, String busqueda) {

            dgw.DataSource = Acceso.Seleccion.GetCursosBuscados(busqueda).Tables[0];
            dgw.DataBind();

        }

    }
}