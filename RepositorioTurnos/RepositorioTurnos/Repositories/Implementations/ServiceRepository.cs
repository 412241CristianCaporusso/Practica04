
using RepositorioTurnos.Models;
using RepositorioTurnos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioTurnos.Repositories.Implementations
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly TurnosDbContext _turnosDbContext;

        public ServiceRepository(TurnosDbContext turnosDbContext)
        {
            _turnosDbContext = turnosDbContext;
        }

        public bool editarServicio(TServicio service)
        {
            throw new NotImplementedException();
        }

        public bool eliminarServicio(int id)
        {
            throw new NotImplementedException();
        }

        public TServicio? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TServicio> ObtenerServicio()
        {
            throw new NotImplementedException();
        }

        public bool registarServicio(TServicio service)
        {
            throw new NotImplementedException();
        }
    }
}
