using AutoMapper;
using Data;
using DataEntities;
using Dto;
using Negocio.Interfaz;
using System;
using System.Collections.Generic;


namespace Negocio
{
    public class BLLibro : IBLLibro
    {
        private readonly DTLibro dTLibro = new DTLibro();

        private readonly IMapper _mapper;

     

        public BLLibro(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<DtoLibro> Buscar(DtoLibro dtoLibro)
        {
            try
            {
                List<Libro> objLibro = this.dTLibro.Buscar(x => x.IdLibro == (dtoLibro.IdLibro ?? x.IdLibro) &&
                  x.Titulo.ToLower() == (dtoLibro.Titulo != string.Empty ? dtoLibro.Titulo.ToLower() : x.Titulo.ToLower())
                  && x.IdEditorial == (dtoLibro.IdEditorial ?? x.IdEditorial) && x.Fecha >= (dtoLibro.Fecha ?? x.Fecha) && x.Fecha <= (dtoLibro.Fecha ?? x.Fecha)
                  && x.Autor.ToLower() == (dtoLibro.Autor != string.Empty ? dtoLibro.Autor.ToLower() : x.Autor.ToLower())
                  );
               
                List<DtoLibro> lsdtoLibro = _mapper.Map<List<DtoLibro>>(objLibro);
           
                return lsdtoLibro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DtoLibro Crear(DtoLibro dtoLibro)
        {
            try
            {
                Libro objLibro = _mapper.Map<Libro>(dtoLibro);

                objLibro = this.dTLibro.Adicionar(objLibro);
                DtoLibro dtoFactu = _mapper.Map<DtoLibro>(objLibro);
                return dtoFactu;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public List<DtoLibro> GetAll()
        {
            List<Libro> objLibro = this.dTLibro.GetAll();
            List<DtoLibro> lsdtoLibro = _mapper.Map<List<DtoLibro>>(objLibro);

            return lsdtoLibro;
        }

        public DtoLibro GetUno(DtoLibro dtoLibro)
        {
            try
            {
                Libro objLibro = this.dTLibro.TraerUno(x => x.IdLibro == (dtoLibro.IdLibro ??  x.IdLibro) &&
                   x.Titulo.ToLower() == (dtoLibro.Titulo != string.Empty ? dtoLibro.Titulo.ToLower() : x.Titulo.ToLower())
                   && x.IdEditorial == (dtoLibro.IdEditorial ?? x.IdEditorial) && x.Fecha >= (dtoLibro.Fecha ?? x.Fecha) && x.Fecha <= (dtoLibro.Fecha ?? x.Fecha)
                   && x.Autor.ToLower() == (dtoLibro.Autor != string.Empty ? dtoLibro.Autor.ToLower() : x.Autor.ToLower())
                   );
                dtoLibro = _mapper.Map<DtoLibro>(objLibro);
                return dtoLibro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DtoLibro Modificar(DtoLibro dtoLibro)
        {
            try
            {
                Libro objLibro = this.dTLibro.TraerUno(x => x.IdLibro == dtoLibro.IdLibro);
                objLibro.IdLibro = dtoLibro.IdLibro.Value;
                objLibro.Titulo = dtoLibro.Titulo;
                objLibro = this.dTLibro.Modificar(objLibro);
                DtoLibro dtoFactu = this._mapper.Map<DtoLibro>(objLibro);
                   
                return dtoFactu;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
