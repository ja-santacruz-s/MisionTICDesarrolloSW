using GanaderiaWeb.App.Dominio;
using GanaderiaWeb.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace GanaderiaWeb.App.Persistencia
{
    public class RepositorioLoteGanado : IRepositorioLoteGanado
    {
        private readonly AppContext _appContext;

        public RepositorioLoteGanado(AppContext appContext) {
            _appContext = appContext;
        }

        LoteGanado IRepositorioLoteGanado.AddLoteGanado(LoteGanado loteGanado){
            var loteGanadoAdicionado =  _appContext.LotesGanado.Add(loteGanado);
            _appContext.SaveChanges();
            return loteGanadoAdicionado.Entity;
        }

        IEnumerable<LoteGanado> IRepositorioLoteGanado.GetAllLotesGanado() {
            return _appContext.LotesGanado;
        }

        LoteGanado IRepositorioLoteGanado.UpdateLoteGanado(LoteGanado loteGanado) {
            var loteGanadoEncontrado = _appContext.LotesGanado.FirstOrDefault(g => g.Id == loteGanado.Id);
            if (loteGanadoEncontrado != null) {


                _appContext.SaveChanges();
            }
            return loteGanadoEncontrado;
        }

        bool IRepositorioLoteGanado.DeleteLoteGanado(int idLoteGanado) {
            var loteGanadoEncontrado = _appContext.LotesGanado.FirstOrDefault(g => g.Id == idLoteGanado);
            if (loteGanadoEncontrado != null) {
                _appContext.LotesGanado.Remove(loteGanadoEncontrado);
                _appContext.SaveChanges();
                return true;
            }
            return false;
        }

        LoteGanado IRepositorioLoteGanado.GetLoteGanadoById(int idLoteGanado) {
            var lotGanadoEncontrado = _appContext.LotesGanado.FirstOrDefault(g => g.Id == idLoteGanado);            
            return lotGanadoEncontrado;
        }
    }
}