using Data.Interfaces;
using DataEntities;
using DataModelo;
using Microsoft.Extensions.Configuration;
using PruebaConexion.Modelos;
using Repositorio;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data
{
    public class LibroRepository: ILibroRepository
    {
        private readonly Repository<Libro> repocitorio;


        public LibroRepository()
        {
            repocitorio = new Repository<Libro>(new MakersDBContext());
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

        public void Guardar()
        {
            this.repocitorio.Guardar() ;
        }

        public Libro Modificar(Libro Entidad)
        {
            this.repocitorio.Modificar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public Libro TraerUltimo(Expression<Func<Libro, bool>> predicado)
        {
           return this.repocitorio.TraerUltimo(predicado);
        }

        public Libro TraerUno(Expression<Func<Libro, bool>> predicado)
        {
            return this.repocitorio.TraerUno(predicado);
        }

    }
}
