using MagiVilla_api.datos;
using MagiVilla_api.modelos;
using MagiVilla_api.modelos.dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagiVilla_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaList;
        
        }

        [HttpGet("id")] 
        //le damos el nombre al que 
        public VillaDto GetVilla(int id)
        {
            //hacemos una función de flecha con la letra v, y luego sacamos la letra v y la comparamos
            return VillaStore.villaList.FirstOrDefault(v => v.Id == id); 
        }

    }
}
