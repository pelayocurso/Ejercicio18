using Ejercicio18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18.Repository
{
    public interface IEntradaRepository
    {
        Entrada Create(Entrada entrada);
        Entrada Read(long id);
        void Update(Entrada entrada);
        void Delete(Entrada entrada);
        IQueryable<Entrada> All();
    }
}
