﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sender.DTO;
using Sender.Services;

namespace Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsignorController : ControllerBase
    {
        private readonly IConsignor _IConsignor;

        public ConsignorController(IConsignor iConsignor)
        {
            _IConsignor = iConsignor;
        }

        [HttpGet("GetConsignor")]
        public ActionResult<Consignor> GetConsignor(string Name)
        {
            return Ok(_IConsignor.GetConsignor(Name));
        }

        [HttpPost("AddConsignor")]
        public ActionResult<ConsignorDTO>AddConsingnor(ConsignorDTO consignorDTO)
        {
            _IConsignor.AddConsignor(consignorDTO);
            return consignorDTO;
        }
    }
}
