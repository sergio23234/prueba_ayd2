using Conexion;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conexion.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void ComprobarTest()
        {
            Form1 form = new Form1();
            Boolean resultado=form.Comprobar("Admin","12345");
            Assert.ReferenceEquals(resultado,false);
        }
    }
}

namespace conexion_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
