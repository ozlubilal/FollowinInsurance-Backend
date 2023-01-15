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
    public class InsuranceStatesController : ControllerBase
    {
        IInsuranceStateService _insuranceStateService;
        public InsuranceStatesController(IInsuranceStateService insuranceStateService)
        {
            _insuranceStateService = insuranceStateService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _insuranceStateService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _insuranceStateService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(InsuranceState insuranceState)
        {
            var result = _insuranceStateService.Add(insuranceState);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(InsuranceState insuranceState)
        {
            var result = _insuranceStateService.Delete(insuranceState);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(InsuranceState insuranceState)
        {
            var result = _insuranceStateService.Update(insuranceState);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
