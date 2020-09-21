using Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Negocio.Tests
{
    [TestClass()]
    public class BLLibroTests
    {
        BLLibro _bLLibro = new BLLibro();


        [TestMethod()]
        public void CrearTest()
        {
            try
            {
                Assert.IsTrue(this._bLLibro.Crear(new DtoLibro() {
                    Titulo = "Titulo m",
                    IdEditorial = 1,
                    Autor = "Autor Prueba",
                    Fecha = DateTime.Now,
                    Costo = 90000,
                    PrecioSugerido = 9900
                }).IdLibro != 0
                );
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void BuscarTest()
        {
            try
            {
                Assert.IsTrue(this._bLLibro.Buscar(new DtoLibro() { Titulo = "Titulo m" }).Count > 0);
            }
            catch (Exception)
            {

                Assert.Fail();
            }

        }


       

        [TestMethod()]
        public void GetAllTest()
        {
            try
            {
                Assert.IsTrue(this._bLLibro.GetAll().Count > 0);

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetUnoTest()
        {
            try
            {
                Assert.IsTrue(this._bLLibro.GetUno(new DtoLibro() { IdLibro = 1 }).IdLibro > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ModificarTest()
        {
            try
            {
                
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
    }
}