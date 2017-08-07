using Ejercicio18.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ejercicio18.Models;
using Ejercicio18.Exceptions;
using System.Data.Entity.Infrastructure;

namespace Ejercicio18.Service
{
    public class EntradaService : IEntradaService
    {
        //[ThreadStatic]public static ApplicationDbContext applicationDbContext;

        private IEntradaRepository entradaRepository;
        public EntradaService(IEntradaRepository _entradaRepository)
        {
            this.entradaRepository = _entradaRepository;
        }

        public Entrada Create(Entrada entrada)
        {
            return entradaRepository.Create(entrada);
        }

        public Entrada Read(long id)
        {
            return entradaRepository.Read(id);
        }

        public void Update(Entrada entrada)
        {
            entradaRepository.Update(entrada);
        }

        public void Delete(long id)
        {
            Entrada entrada = entradaRepository.Read(id);
            entradaRepository.Delete(entrada);
        }

        public IQueryable<Entrada> All()
        {
            IQueryable<Entrada> entradas;
            entradas = entradaRepository.All();
            return entradas;
        }
    }
}