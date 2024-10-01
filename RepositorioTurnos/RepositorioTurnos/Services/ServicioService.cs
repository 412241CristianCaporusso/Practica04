
using RepositorioTurnos.Models;
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


        public void editarServicio(TServicio service)
        {
             _serviceRepository.editarServicio(service);
        }

        public void eliminarServicio(int id)
        {
             _serviceRepository.eliminarServicio(id);
        }

        public TServicio? GetByID(int id)
        {
            return _serviceRepository.GetByID(id);
        }

        public TServicio? GetByName(string name)
        {
            return _serviceRepository.GetByName(name);
        }

        public List<TServicio> ObtenerServicio()
        {
            return _serviceRepository.ObtenerServicio();
        }

        public void registarServicio(TServicio service)
        {
            _serviceRepository.registarServicio(service);  
        }
    }
}
