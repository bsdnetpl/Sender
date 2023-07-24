using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sender.DTO;

namespace Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosController : ControllerBase
    {
        [HttpPost("AddPos")]
        public ActionResult<PosDTO> AddPos(PosDTO posDTO)
        {

        }
    }
}
