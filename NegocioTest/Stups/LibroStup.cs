using DataEntities;
using Dto;
using System;
using System.Collections.Generic;

namespace NegocioTest.Stups
{
    public static class LibroStup
    {
        public static Libro dtoLibro = new Libro()
        {
            Titulo = "titulo m",
            IdLibro = 1,
            Fecha = DateTime.Now
        };

        public static List<Libro> list = new List<Libro>()
        {
            new Libro
            {
                Titulo = "titulo m",
                IdLibro = 1,
                Fecha = DateTime.Now,
                IdEditorial = 1,
                Costo = 9000
            },
            new Libro
            {

                Titulo = "titulo 1",
                IdLibro = 1,
                Fecha = DateTime.Now,
                IdEditorial = 2,
                Costo = 9001
            }
        };
    }
}
