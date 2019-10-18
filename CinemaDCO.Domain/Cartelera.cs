using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
