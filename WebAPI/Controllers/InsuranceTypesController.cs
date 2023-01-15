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
    public class InsuranceTypesController : ControllerBase
    {
        IInsuranceTypeService _insuranceTypeService;
        public InsuranceTypesController(IInsuranceTypeService insuranceTypeService)
        {
            _insuranceTypeService = insuranceTypeService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _insuranceTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _insuranceTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(InsuranceType insuranceType)
        {
            var result = _insuranceTypeService.Add(insuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(InsuranceType insuranceType)
        {
            var result = _insuranceTypeService.Update(insuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(InsuranceType insuranceType)
        {
            var result = _insuranceTypeService.Delete(insuranceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
