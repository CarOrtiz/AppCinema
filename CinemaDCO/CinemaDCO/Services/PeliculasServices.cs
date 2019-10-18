using CinemaDCO.Domain;
using CinemaDCO.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaDCO.Services
{
    class PeliculasServices
    {
        public static List<Cartelera> GetPeliculas()
        {
            var Cartelera = ApiHelpers.Get<List<Cartelera>>("/api/Cartelera");
            return Cartelera;
        }
        public static Permiso Login(Usuarios usuario)
        {
                var respuesta = ApiHelpers.Post<Permiso>("/api/Seguridad", usuario);
                return respuesta;
        }
    }

    
    
}
