using System;
using GanaderiaWeb.App.Dominio;
using GanaderiaWeb.App.Persistencia;

namespace GanaderiaWeb.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            GetAllGanaderos();
        }

        private static void AddGanadero() {
            var ganadero = new Ganadero {
                Nombres = "Mario",
                Apellidos = "Perez",
                NumeroTelefono = "3224445555",
                Direccion = "Calle 12 No. 7-18",
                Correo = "m.perezs@gmail.com",
                Contrasena = "123abc",
                Latitud = 7.455F,
                Longitud = 5.533F
            };

            _repoGanadero.AddGanadero(ganadero);

        }

        private static void GetAllGanaderos() {
            var ganaderos = _repoGanadero.GetAllGanaderos();
            foreach (Ganadero item in ganaderos) {
                Console.WriteLine(item.Nombres);
            }
        }
    }
}
