
using RepositorioTurnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioTurnos.Repositories.Contracts
{
    public  interface IServiceRepository
    {

        List<TServicio> ObtenerServicio();

        TServicio? GetByID(int id);

        bool registarServicio(TServicio service);

        bool editarServicio(TServicio service);

        bool eliminarServicio(int id);



    }
}
