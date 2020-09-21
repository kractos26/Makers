using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ent = DataEntity;
namespace Mapeo
{
   public class Mapeo
    {
        public void MapearEntidadeModeo()
        {
            #region mapas entidad a modelos
            Mapper.CreateMap<ent.Libro, Dto.DtoLibro>();
            Mapper.CreateMap<ent.Editorial, Dto.DtoEditorial>();
            Mapper.CreateMap<ent.Compra, Dto.DtoCompra>();



            #endregion
        }

        /// <summary>
        /// Configuracion del mapeo de modelo a entidades.
        /// </summary>
        public void MapearModeloEntidad()
        {
            #region mapas entidad a modelos
            Mapper.CreateMap<Dto.DtoCompra, ent.Compra>();
            Mapper.CreateMap<Dto.DtoLibro, ent.Libro>();
            Mapper.CreateMap<Dto.DtoEditorial, ent.Editorial>();
            #endregion
        }
    }
}
