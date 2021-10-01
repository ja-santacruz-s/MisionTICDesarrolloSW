using System;

namespace GanaderiaWeb.App.Dominio
{
    public class LoteGanado
    {
        public int Id { get; set;}
        public DateTime FechaRegistro { get; set;}
        public int IdGanadero { get; set;}
        public int CantidadEjemplares { get; set;}
        public int TotalHembras { get; set;}   
        public int TotalMachos { get; set;}
        public int TotalMenos1Anio { get; set;}
        public int Total1a2Anios { get; set;}
        public int Total2a3Anios { get; set;}
        public int TotalMas3Anios { get; set;}
        /// <summary>
        /// Cebuino (Bos Indicus): Razas como Nelore, Guzerá, Indubrasil y Gyr; así como el Brahman 
        /// </summary>
        public int CantidadCebuino { get; set;}
        /// <summary>
        /// Taurino (Bos Tauros): Razas como Aberdeen Angus, Limousin, Hereford, Shorthorn, Charolaise, Romagnola, Chianina, Pardo Suizo, Holstein, Jersey, Ayrshire, Normando, Rojo Sueco
        /// </summary>
        public int CantidadTaurino { get; set;}
        /// <summary>
        /// Cruces entre razas
        /// </summary>
        public int CantidadCriollo { get; set;}
        public int Valor { get; set;}
        
    }
}