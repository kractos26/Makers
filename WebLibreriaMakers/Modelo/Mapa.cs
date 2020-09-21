using AutoMapper;
using DataEntities;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibreriaMakers.Modelo
{
    public class UserProfile:Profile
    {
      public UserProfile()
        {
            CreateMap<DtoLibro, Libro>();
            CreateMap<DtoEditorial, Editorial>();

            CreateMap<Libro, DtoLibro>();
            CreateMap<Editorial, DtoEditorial>();

        }
    }
}
