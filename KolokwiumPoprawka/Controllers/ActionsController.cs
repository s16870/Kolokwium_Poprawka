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
    [Route("api/actions")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        private readonly IFireFightersService _fireFightersService;

        public ActionsController(IFireFightersService fireFightersService)
        {
            _fireFightersService = fireFightersService;
        }
        [HttpPost]
        [Route("{actionId}/fire-trucks")]
        public IActionResult GetFirefighterActions([FromQuery] int actionId, AssignTruckRequest req)
        {
            try
            {
                return Ok(_fireFightersService.AssignTruck(req));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}