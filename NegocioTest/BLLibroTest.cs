using AutoMapper;
using Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Negocio;
using Negocio.Interfaz;
using NegocioTest.Config;
using NegocioTest.MockRepositorio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace NegocioTest
{
    class BLLibroTest
    {
        private static IBLLibro _bLLibro;
        [ClassInitialize]
        public static void Setup(TestContext context)
        {

            Mock<ILibroRepository> mockRepositorioLibro = new MockRepositorioLibro()._bllibrorepository;
            Mock<IMapper> automaper = new MockAutomapper()._mapper;
            _bLLibro = new BLLibro(mockRepositorioLibro.Object, automaper.Object);
            //BLLibro = new BLLibro();
        }

        [TestMethod()]
        public void CrearTest()
        {
            try
            {
                Assert.IsTrue(_bLLibro.Crear(new DtoLibro()
                {
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
                Assert.IsTrue(_bLLibro.Buscar(new DtoLibro() { Titulo = "Titulo m" }).Count > 0);
            }
            catch (Exception)
            {

                Assert.Fail();
            }

        }




        [TestMethod]
        public void GetAllTest()
        {
            try
            {
                Assert.IsTrue(_bLLibro.GetAll().Count > 0);

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetUnoTest()
        {
            try
            {
                Assert.IsTrue(_bLLibro.GetUno(new DtoLibro() { IdLibro = 1 }).IdLibro > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
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
