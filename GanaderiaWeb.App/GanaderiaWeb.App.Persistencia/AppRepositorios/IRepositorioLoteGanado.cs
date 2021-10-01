using GanaderiaWeb.App.Dominio;
using System.Collections.Generic;

namespace GanaderiaWeb.App.Persistencia
{
    public interface IRepositorioLoteGanado
    {
        LoteGanado AddLoteGanado(LoteGanado loteGanado);

        IEnumerable<LoteGanado> GetAllLotesGanado();

        LoteGanado UpdateLoteGanado(LoteGanado loteGanado);

        bool DeleteLoteGanado(int idLoteGanado);

        LoteGanado GetLoteGanadoById(int idLoteGanado);
    }
}