using MagiVilla_api.modelos.dto;

namespace MagiVilla_api.datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { Id = 1, nombre = "wilfer Andres" },
            new VillaDto { Id = 2, nombre = "lilibet bermeo" },
            new VillaDto { Id = 3, nombre = "freiman ordoñez"}
        };
    }
}
