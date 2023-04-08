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
            return new List<VillaDto>
        {
            new VillaDto {Id = 1, nombre = "vista a la piscina"},
            new VillaDto {Id = 2, nombre = "vista a la playa"}
        };
        }
    }
}
