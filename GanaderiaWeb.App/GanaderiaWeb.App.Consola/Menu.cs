namespace GanaderiaWeb.App.Consola
{
    public class Menu
    {
        private int opcion;
        public void mostrarMenu() {
            do {
                Console.writeLine("MENU PRINCIPAL");
                Console.writeLine("1. Ganaderos ");
                Console.writeLine("2. Lotes de ganado");
                Console.writeLine("Opcion: ");
                opcion =  Convert.ToInt32(Console.ReadLine());
            }while(opcion != 3);
        }

        public void mostrarMenuGanadero() {
            do {
                Console.writeLine("MENU GANADERO");
                Console.writeLine("1. Acicionar ");
                Console.writeLine("2. Listar");
                Console.writeLine("2. Modificar");
                Console.writeLine("2. Eliminar");
                Console.writeLine("2. Buscar por identificación");
                Console.writeLine("Opcion: ");
                opcion =  Convert.ToInt32(Console.ReadLine());
                switch (opcion) {
                    case 1: break;
                }
            }while(opcion != 5);
        }
    }
}