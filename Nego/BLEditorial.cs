using AutoMapper;
using Data;
using DataEntities;
using Dto;
using Negocio.Interfaz;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLEditorial : IBLEditorial
    {
        private readonly DTEditorial dTEditorial = new DTEditorial();
        private readonly IMapper _mapper;
        public BLEditorial(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<DtoEditorial> Buscar(DtoEditorial dtoEditorial)
        {
            try
            {
                List<Editorial> objEditorial = this.dTEditorial.Buscar(x => x.IdEditorial == (dtoEditorial.IdEditorial > 0 ? dtoEditorial.IdEditorial : x.IdEditorial) &&
                  x.Nombre.ToLower() == (dtoEditorial.Nombre != string.Empty ? dtoEditorial.Nombre.ToLower() : x.Nombre.ToLower())

                  );
                List<DtoEditorial> lsdtoEditorial = _mapper.Map<List<DtoEditorial>>(objEditorial);

                
                return lsdtoEditorial;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DtoEditorial Crear(DtoEditorial dtoEditorial)
        {
            throw new NotImplementedException();
        }

        public List<DtoEditorial> GetAll(DtoEditorial dtoEditorial)
        {
            try
            {
                List<Editorial> objEditorial = this.dTEditorial.GetAll();
                List<DtoEditorial> lsdtoEditorial = _mapper.Map<List<DtoEditorial>>(objEditorial);
                return lsdtoEditorial;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DtoEditorial GetUno(DtoEditorial dtoEditorial)
        {
            try
            {
                Editorial objEditorial = this.dTEditorial.TraerUno(x => x.IdEditorial == (dtoEditorial.IdEditorial > 0 ? dtoEditorial.IdEditorial : x.IdEditorial) &&
                   x.Nombre.ToLower() == (dtoEditorial.Nombre != string.Empty ? dtoEditorial.Nombre.ToLower() : x.Nombre.ToLower())

                   );
                dtoEditorial = _mapper.Map<DtoEditorial>(objEditorial);
                return dtoEditorial;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DtoEditorial Modificar(DtoEditorial dtoEditorial)
        {
            throw new NotImplementedException();
        }
    }
}
