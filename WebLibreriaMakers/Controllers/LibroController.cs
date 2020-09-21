using Microsoft.AspNetCore.Mvc;
using Negocio;
using Negocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Net;
using WebLibreriaMakers.Modelo;

namespace WebLibreriaMakers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly IBLLibro _bllibro;

        public LibroController(IBLLibro bLLibro)
        {
            _bllibro = bLLibro;
        }
        /// <summary>
        /// Buscar libros
        /// </summary>
        /// <param name="libro">Contiene los filtros</param>
        /// <returns>Retora la lista de libros</returns>
        [HttpGet()]
        [Route("Buscar")]
        public ActionResult<Response<List<Dto.DtoLibro>>> Buscar([FromQuery]Dto.DtoLibro libro)
        {
            Response<List<Dto.DtoLibro>> response = new Response<List<Dto.DtoLibro>>();
            try
            {
                response.Entidad = _bllibro.Buscar(libro);
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.Found;
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Buscar libros
        /// </summary>
        /// <param name="libr">Contiene los filtros.</param>
        /// <returns>Retorna la lista de libros.</returns>
        [HttpGet]
        [Route("TraerUno")]
        public ActionResult<Dto.DtoLibro> TraerUno([FromQuery]Dto.DtoLibro libr)
        {
            Response<Dto.DtoLibro> response = new Response<Dto.DtoLibro>();
            try
            {
                response.Entidad = _bllibro.GetUno(libr);
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Obtiene todos los libros
        /// </summary>
        /// <returns>Lista de libros.</returns>
        [HttpGet]
        [Route("Todos")]
        public ActionResult<Dto.DtoLibro> GetAll()
        {
            Response<List<Dto.DtoLibro>> response = new Response<List<Dto.DtoLibro>>();
            try
            {
                response.Entidad = _bllibro.GetAll();
                response.Status = HttpStatusCode.Found;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }

        [HttpPost]
        public ActionResult<Dto.DtoLibro> Crea(Dto.DtoLibro dtoLibro)
        {
            Response<Dto.DtoLibro> response = new Response<Dto.DtoLibro>();
            try
            {
                response.Entidad = _bllibro.Crear(dtoLibro);
                response.Status = HttpStatusCode.Created;

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }

        [HttpPut]
        public ActionResult<Dto.DtoLibro> Modificar(Dto.DtoLibro dtoLibro)
        {
            Response<Dto.DtoLibro> response = new Response<Dto.DtoLibro>();
            try
            {
                response.Entidad = _bllibro.Modificar(dtoLibro);
                response.Status = HttpStatusCode.Created;

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }

    }
}
