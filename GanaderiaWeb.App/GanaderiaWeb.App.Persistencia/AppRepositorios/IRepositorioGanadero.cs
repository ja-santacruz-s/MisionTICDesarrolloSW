using GanaderiaWeb.App.Dominio;
using System.Collections.Generic;

namespace GanaderiaWeb.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero);

        IEnumerable<Ganadero> GetAllGanaderos();

        Ganadero UpdateGanadero(Ganadero ganadero);

        bool DeleteGanadero(int idGanadero);

        Ganadero getGanaderoById(int idGanadero);
    }
}