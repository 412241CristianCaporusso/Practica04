
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

        TServicio? GetByName(string name);
        
        void registarServicio(TServicio service);

        void editarServicio(TServicio service);

        void eliminarServicio(int id);



    }
}
