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
    public class TrafficInsurancesController : ControllerBase
    {
        ITrafficInsuranceService _trafficInsuarnaceService;
        public TrafficInsurancesController(ITrafficInsuranceService trafficInsuranceService)
        {
            _trafficInsuarnaceService = trafficInsuranceService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _trafficInsuarnaceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _trafficInsuarnaceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getalltrafficinsurancelistdto")]
        public IActionResult GetListTrafficInsuranceListDto()
        {
            var result = _trafficInsuarnaceService.GetAllTrafficInsuranceListDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("gettrafficinsurancelistdtobyid")]
        public IActionResult GetTrafficInsuranceListDtoById(int id)
        {
            var result = _trafficInsuarnaceService.GetTrafficInsuranceListDtoById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(TrafficInsurance trafficInsurance)
        {
            var result = _trafficInsuarnaceService.Add(trafficInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TrafficInsurance trafficInsurance)
        {
            var result = _trafficInsuarnaceService.Delete(trafficInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(TrafficInsurance trafficInsurance)
        {
            var result = _trafficInsuarnaceService.Update(trafficInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
