using System;
using System.Collections.Generic;

namespace CinemaDCO.Domain
{
    public class Cartelera
    {
        public string Nombre { get; set; }
        public string FechaEstreno { get; set; }
        public string Genero { get; set; }
        public string Recomendaciones { get; set; }
        public string Duracion { get; set; }
        public string Imagen { get; set; }
        public List<Funcion> Funciones { get; set; }

        public string Sala { get; set; }
        public string Ciudad { get; set; }
        public int Precio { get; set; }
    }
}
