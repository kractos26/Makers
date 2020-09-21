using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Data.Interfaces
{
   public interface IDTEditorial
    {
        Editorial Adicionar(Editorial Editorial);
        List<Editorial> Buscar(Expression<Func<Editorial, bool>> predicado);
        Editorial Eliminar(Editorial Entidad);
        List<Editorial> GetAll();
        Editorial Modificar(Editorial Entidad);
        Editorial TraerUno(Expression<Func<Editorial, bool>> predicado);
    }
}
