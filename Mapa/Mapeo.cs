using AutoMapper;
using DataEntities;
using Dto;
namespace Mapeo

{
    public class Mapeo
    {
        private readonly IMapper _mapper;

        Mapeo(IMapper mapper)
        {

            _mapper = mapper;
          

        }
        public void MapearEntidadeModeo()
        {
            #region mapas entidad a modelos

            Mapper maps = new Mapper();
           
            CreateMap<Libro, DtoLibro>();
            CreateMap<Editorial, DtoEditorial>();
            CreateMap<Compra, Dto.DtoCompra>();



            #endregion
        }

        /// <summary>
        /// Configuracion del mapeo de modelo a entidades.
        /// </summary>
        public void MapearModeloEntidad()
        {
            #region mapas entidad a modelos
            CreateMap<DtoCompra,Compra>();
            CreateMap<DtoLibro, Libro>();
            CreateMap<DtoEditorial, Editorial>();
            #endregion
        }
    }
}
