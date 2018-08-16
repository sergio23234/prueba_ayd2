using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aplicacion_web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void si_existe_usuario()
        {
            conexion cn = new conexion();
            Assert.AreEqual(cn.credenciales("danialjim", "danialjim1234"), true);
        }

        [TestMethod]
        public void no_existe_usuario()
        {
            conexion cn = new conexion();
            Assert.AreEqual(cn.credenciales("este usuario", "no existe"), false);
        }
    }
}
