using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KolokwiumPoprawka.Services;
using KolokwiumPoprawka.DTO.Request;

namespace KolokwiumPoprawka.Controllers
{
    [Route("api/firefighters")]
    [ApiController]
    public class FireFightersController : ControllerBase
    {
        private readonly IFireFightersService _fireFightersService;

        public FireFightersController(IFireFightersService fireFightersService)
        {
            _fireFightersService = fireFightersService;
        }
        [HttpGet]
        [Route("{fireFighterId}/actions")]
        public IActionResult GetFirefighterActions(int fireFighterId)
        {
            try
            {
                return Ok(_fireFightersService.GetFireFighterActions(firefighterid));
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}