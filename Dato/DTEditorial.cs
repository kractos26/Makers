﻿using Data.Interfaces;
using DataEntities;
using Microsoft.Extensions.Configuration;
using PruebaConexion.Modelos;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;



namespace Data
{
    public class DTEditorial
    {
        

        private readonly Repository<Editorial> repocitorio;

        public DTEditorial()
        {
            repocitorio = new Repository<Editorial>(new MakersDBContext());
        }

        public Editorial Adicionar(Editorial Editorial)
        {
            this.repocitorio.Adicionar(Editorial);
            this.repocitorio.Guardar();
            return Editorial;
        }

        public List<Editorial> Buscar(Expression<Func<Editorial, bool>> predicado)
        {
            return this.repocitorio.Buscar(predicado);
        }


        public Editorial Eliminar(Editorial Entidad)
        {
            this.repocitorio.Eliminar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public List<Editorial> GetAll()
        {
            return this.repocitorio.GetAll();
        }

        public Editorial Modificar(Editorial Entidad)
        {
            this.repocitorio.Modificar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public Editorial TraerUno(Expression<Func<Editorial, bool>> predicado)
        {
            return this.repocitorio.TraerUno(predicado);
        }
    }
}
