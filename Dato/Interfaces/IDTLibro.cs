using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Interfaces
{
   public interface IDTLibro
    {
        Libro Adicionar(Libro Libro);
        List<Libro> Buscar(Expression<Func<Libro, bool>> predicado);
        Libro Eliminar(Libro Entidad);
        List<Libro> GetAll();
        Libro Modificar(Libro Entidad);
        Libro TraerUno(Expression<Func<Libro, bool>> predicado);
    }
}
