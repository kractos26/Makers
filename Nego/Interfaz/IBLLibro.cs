using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaz
{
   public interface IBLLibro
    {
        DtoLibro Crear(DtoLibro dtoLibro);
        DtoLibro Modificar(DtoLibro dtoLibro);
        List<DtoLibro> GetAll();
        DtoLibro GetUno(DtoLibro dtoLibro);
        List<DtoLibro> Buscar(DtoLibro dtoLibro);
    }
}
