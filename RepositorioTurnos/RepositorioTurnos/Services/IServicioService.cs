using RepositorioTurnos.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioTurnos.Services
{
    public interface IServicioService
    {
        List<Servicio> ObtenerServicio();

        Servicio? GetByID(int id);

        bool registarServicio(Servicio service);

        bool editarServicio(Servicio service);

        bool eliminarServicio(int id);


    }
}
