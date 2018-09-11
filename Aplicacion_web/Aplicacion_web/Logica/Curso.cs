using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion_web.Logica
{
    public class Curso
    {
        private String codigo;
        private String nombre;
        private String area;

        public Curso(String codigo, String nombre, String area) {
            this.codigo = codigo;
            this.nombre = nombre;
            this.area = area;
        }
        public void setCodigo(String codigo) {
            this.codigo = codigo;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setArea(String Area)
        {
            this.area = Area;
        }

        public String getCodigo() {
            return this.codigo;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getArea()
        {
            return this.area;
        }

    }
}