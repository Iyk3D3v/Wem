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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Add(CustomerDto dto)
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var res = await _service.GetAll();
                return Ok(new ResponseDto { 
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
