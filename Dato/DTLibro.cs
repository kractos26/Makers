using Data.Interfaces;
using DataEntities;
using Microsoft.Extensions.Configuration;
using PruebaConexion.Modelos;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data
{
    public class DTLibro
    {
        private readonly Repository<Libro> repocitorio;

        public DTLibro()
        {
            repocitorio = new Repository<Libro>(new MakersContext(""));
        }
        public Libro Adicionar(Libro Libro)
        {
            this.repocitorio.Adicionar(Libro);
            this.repocitorio.Guardar();
            return Libro;
        }

        public List<Libro> Buscar(Expression<Func<Libro, bool>> predicado)
        {
            return this.repocitorio.Buscar(predicado);
        }


        public Libro Eliminar(Libro Entidad)
        {
            this.repocitorio.Eliminar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public List<Libro> GetAll()
        {
            return this.repocitorio.GetAll();
        }

        public Libro Modificar(Libro Entidad)
        {
            this.repocitorio.Modificar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public Libro TraerUno(Expression<Func<Libro, bool>> predicado)
        {
            return this.repocitorio.TraerUno(predicado);
        }

    }
}
