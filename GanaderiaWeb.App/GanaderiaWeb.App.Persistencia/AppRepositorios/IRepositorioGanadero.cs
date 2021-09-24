using GanaderiaWeb.App.Dominio;
using System.Collections.Generic;

namespace GanaderiaWeb.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero);

        IEnumerable<Ganadero> GetAllGanaderos();
    }
}