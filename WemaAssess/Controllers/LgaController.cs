using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WemaAssess.Data.Dtos;
using WemaAssess.Data.Services.Interfaces;

namespace WemaAssess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LgaController : ControllerBase
    {
        private ILgaService _service;

        public LgaController(ILgaService service)
        {
            _service = service;
        }

        //this is to make sure the lga is mapped to its state
        [HttpGet]
        public async Task<IActionResult> GetByState(int id)
        {
            try
            {
                var res = await _service.GetByStateId(id);
                return Ok(new ResponseDto
                {
                    Data = res,
                    Message = "Success",
                    Status = true
                });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
