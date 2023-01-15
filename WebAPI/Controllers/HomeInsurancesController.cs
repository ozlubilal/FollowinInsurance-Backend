using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeInsurancesController : ControllerBase
    {
        IHomeInsuranceService _homeInsuranceService;
        public HomeInsurancesController(IHomeInsuranceService homeInsuranceService)
        {
            _homeInsuranceService = homeInsuranceService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _homeInsuranceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getallhomeinsurancelistdto")]
        public IActionResult GetListHomeInsuranceListDto()
        {
            var result = _homeInsuranceService.GetAllHomeInsuranceListDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _homeInsuranceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("gethomeinsurancelistdtobyid")]
        public IActionResult GetHomeInsuranceListDtoById(int id)
        {
            var result = _homeInsuranceService.GetHomeInsuranceListDtoById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(HomeInsurance homeInsurance)
        {
            var result = _homeInsuranceService.Add(homeInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(HomeInsurance homeInsurance)
        {
            var result = _homeInsuranceService.Delete(homeInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(HomeInsurance homeInsurance)
        {
            var result = _homeInsuranceService.Update(homeInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
