using RepositorioTurnos.Entities;
using RepositorioTurnos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioTurnos.Services
{
    public class ServicioService : IServicioService
    {

        private readonly IServiceRepository _serviceRepository;

        public ServicioService(IServiceRepository serviceRepository) 
        {
            _serviceRepository = serviceRepository;
        }    


        public bool editarServicio(Servicio service)
        {
          return _serviceRepository.editarServicio(service);
        }

        public bool eliminarServicio(int id)
        {
            return _serviceRepository.eliminarServicio(id);
        }

        public Servicio? GetByID(int id)
        {
            return _serviceRepository.GetByID(id);
        }

        public List<Servicio> ObtenerServicio()
        {
            return _serviceRepository.ObtenerServicio();
        }

        public bool registarServicio(Servicio service)
        {
            return _serviceRepository.registarServicio(service);  
        }
    }
}
