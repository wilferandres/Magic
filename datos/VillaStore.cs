using MagiVilla_api.modelos.dto;

namespace MagiVilla_api.datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { Id = 1, nombre = "Carina castro", apellido= "CASTRO"},
             new VillaDto { Id = 2, nombre = "Wilfer andres", apellido= "Ordoñez"},
              new VillaDto { Id = 3, nombre = "Elza pato", apellido= "rojas"},
               new VillaDto { Id = 4, nombre = "Sameul", apellido= "rojas"},
               new VillaDto { Id = 5, nombre = "Sebastian", apellido= "perruno"}
        };
    }
}
