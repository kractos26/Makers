//using Dto;
//using Negocio;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace PruebaUnitarias
//{
//    public class UTLIbro
//    {
//        BLLibro _bLLibro = new BLLibro();

        
//        [Test()]
//        public void CrearTest()
//        {
//            try
//            {
//                Assert.IsTrue(this._bLLibro.Crear(new DtoLibro()
//                {
//                    Titulo = "Titulo m",
//                    IdEditorial = 1,
//                    Autor = "Autor Prueba",
//                    Fecha = DateTime.Now,
//                    Costo = 90000,
//                    PrecioSugerido = 9900
//                }).IdLibro != 0
//                );
//            }
//            catch (Exception ex)
//            {
//                Assert.Fail(ex.Message);
//            }
//        }

//        [Test()]
//        public void BuscarTest()
//        {
//            try
//            {
//                Assert.IsTrue(this._bLLibro.Buscar(new DtoLibro() { Titulo = "Titulo m" }).Count > 0);
//            }
//            catch (Exception)
//            {

//                Assert.Fail();
//            }

//        }




//        [Test]
//        public void GetAllTest()
//        {
//            try
//            {
//                Assert.IsTrue(this._bLLibro.GetAll().Count > 0);

//            }
//            catch (Exception)
//            {
//                Assert.Fail();
//            }
//        }

//        [Test]
//        public void GetUnoTest()
//        {
//            try
//            {
//                Assert.IsTrue(this._bLLibro.GetUno(new DtoLibro() { IdLibro = 1 }).IdLibro > 0);
//            }
//            catch (Exception)
//            {
//                Assert.Fail();
//            }
//        }

//        [Test]
//        public void ModificarTest()
//        {
//            try
//            {

//            }
//            catch (Exception)
//            {

//                Assert.Fail();
//            }
//        }
//    }
//}
