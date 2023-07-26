using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sender.DTO;
using Sender.Services;

namespace Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosController : ControllerBase
    {
        private readonly IPos _pos;

        public PosController(IPos pos)
        {
            _pos = pos;
        }

        [HttpPost("AddPos")]
        public ActionResult<PosDTO> AddPos(PosDTO posDTO)
        {
            _pos.AddPos(posDTO);
            return posDTO;
        }
        [HttpDelete("DeletePos")]
        public ActionResult<string> DeletePos(Guid guidPos)
        {
            return Ok(_pos.DeletePos(guidPos));
        }
        [HttpGet("SeekPos")]
        public ActionResult<Pos> SeekPos(string Name) 
        {
         return Ok(_pos.SeekPos(Name));
        }
    }
}
