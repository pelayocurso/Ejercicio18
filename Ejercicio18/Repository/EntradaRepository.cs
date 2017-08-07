using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ejercicio18.Models;
using Ejercicio18.Service;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Ejercicio18.Repository
{
    public class EntradaRepository : IEntradaRepository
    {
        public Entrada Create( Entrada entrada)
        {
            return ApplicationDbContext.applicationDbContext.Entradas.Add(entrada);
        }

        public Entrada Read ( long id )
        {
            return ApplicationDbContext.applicationDbContext.Entradas.Find(id);
        }

        public void Update (Entrada entrada )
        {
            ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
        }

        public void Delete ( Entrada entrada )
        {
            ApplicationDbContext.applicationDbContext.Entradas.Remove(entrada);
        }

        public IQueryable<Entrada> All()
        {
            IList<Entrada> lista = new List<Entrada>(ApplicationDbContext.applicationDbContext.Entradas);
            return lista.AsQueryable<Entrada>();
        }
    }
}