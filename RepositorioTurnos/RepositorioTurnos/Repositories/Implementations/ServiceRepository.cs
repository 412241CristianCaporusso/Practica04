
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

        public void editarServicio(TServicio service)
        {
           
            if (service != null)
            {
                _turnosDbContext.TServicios.Update(service);
                _turnosDbContext.SaveChanges();
            }
        }

        public void eliminarServicio(int id)
        {
           var servicioDelete = GetByID(id);
           if(servicioDelete != null) 
           { 
            _turnosDbContext.TServicios.Remove(servicioDelete);
            _turnosDbContext.SaveChanges();
           }
        }

        public TServicio? GetByID(int id)
        {
            return _turnosDbContext.TServicios.Find(id);
        }

        public TServicio? GetByName(string name)
        {
            return _turnosDbContext.TServicios.FirstOrDefault(ts => ts.Nombre == name);
        }

        public List<TServicio> ObtenerServicio()
        {
            return _turnosDbContext.TServicios.ToList();
        }

        public void registarServicio(TServicio service)
        {
            _turnosDbContext.TServicios.Add(service);
            _turnosDbContext.SaveChanges();
        }
    }
}
