﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sender.DTO;
using Sender.Services;

namespace Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        private readonly Ibox _ibox;

        public BoxController(Ibox ibox)
        {
            _ibox = ibox;
        }

        [HttpPost("AddBox")]
        public ActionResult<List<Box>> AddBox(BoxDTO boxDTO, Guid PosGuid, Guid ConsignorGuid, Guid CustomerGuid)
        {
            return Ok(_ibox.AddBox(boxDTO, PosGuid, ConsignorGuid, CustomerGuid));
        }
        [HttpGet("SeekBox")]
        public ActionResult<List<Box>> SeekBox(Guid guidBox)
        {
            return Ok(_ibox.SeekBox(guidBox));
        }
        [HttpPut("ReturnBox")]
        public ActionResult<List<Box>> ReturnBox(Guid GuidBox)
        {
            return Ok(_ibox.ReturnBox(GuidBox));
        }
        [HttpPut("PackagePickup")]
        public ActionResult<List<Box>> PackagePickup(Guid BoxGuid, string CodePickup)
        {
            return Ok(_ibox.PackagePickup(BoxGuid,CodePickup));
        }
        [HttpDelete("DeletePackage")]
        public ActionResult<string> DeletePackage(Guid IdPackage)
        {
            return Ok(_ibox.DeletePackage(IdPackage));
        }
    }
}
