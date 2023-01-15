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
    public class TrafficInsuranceTypesController : ControllerBase
    {
        ITrafficInsuranceTypeService _trafficInsuarnaceTypeService;
        public TrafficInsuranceTypesController(ITrafficInsuranceTypeService trafficInsuranceTypeService)
        {
            _trafficInsuarnaceTypeService = trafficInsuranceTypeService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _trafficInsuarnaceTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _trafficInsuarnaceTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(TrafficInsuranceType trafficInsuranceType)
        {
            var result = _trafficInsuarnaceTypeService.Add(trafficInsuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TrafficInsuranceType trafficInsuranceType)
        {
            var result = _trafficInsuarnaceTypeService.Delete(trafficInsuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(TrafficInsuranceType trafficInsuranceType)
        {
            var result = _trafficInsuarnaceTypeService.Update(trafficInsuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
