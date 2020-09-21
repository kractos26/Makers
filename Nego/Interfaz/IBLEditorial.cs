using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaz
{
    interface IBLEditorial
    {
        DtoEditorial Crear(DtoEditorial dtoEditorial);
        DtoEditorial Modificar(DtoEditorial dtoEditorial);
        List<DtoEditorial> GetAll(DtoEditorial dtoEditorial);
        DtoEditorial GetUno(DtoEditorial dtoEditorial);
        List<DtoEditorial> Buscar(DtoEditorial dtoEditorial);
    }
}
