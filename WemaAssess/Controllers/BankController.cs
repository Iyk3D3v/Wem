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
    public class BankController : ControllerBase
    {

        private IBankService _service;
        public BankController(IBankService service)
        {
            _service = service;
        }


        //to get banks
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _service.GetBanks();
                return Ok(new ResponseDto
                {
                    Data = res,
                    Message = "Success",
                    Status = true
                });
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
