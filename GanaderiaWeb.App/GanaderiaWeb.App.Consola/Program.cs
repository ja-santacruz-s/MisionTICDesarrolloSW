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
            //int idGanadero;
            Console.WriteLine("Hello World!");
            //AddGanadero();
            //GetAllGanaderos();
            //UpdateGanadero();
            DeleteGanadero(5);
            /*
            Console.WriteLine("Ingrese la identificacion del ganadero: ");
            idGanadero =  Convert.ToInt32(Console.ReadLine());
            GetGanadero(idGanadero);
            */
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

        private static void UpdateGanadero() {
            var ganadero = new Ganadero {
                Id = 2,
                Nombres = "Rosita",
                Apellidos = "Gutierrez",
                NumeroTelefono = "3224445555",
                Direccion = "Calle 12 No. 7-18",
                Correo = "m.perezs@gmail.com",
                Contrasena = "123abc",
                Latitud = 7.455F,
                Longitud = 5.533F
            };

            _repoGanadero.UpdateGanadero(ganadero);
        }

        private static void DeleteGanadero(int idGanadero) {
            var response = _repoGanadero.DeleteGanadero(idGanadero);
            if (response) 
                Console.WriteLine("El ganadero se elimino correctamente");
            else
                Console.WriteLine("Error no existe un ganadero con ese código");

        }

        private static void GetGanadero(int idGanadero) {
            var ganadero = _repoGanadero.getGanaderoById(idGanadero);
            Console.WriteLine("El nombre del ganadero es: " + ganadero.Nombres);
        }
    }
}
