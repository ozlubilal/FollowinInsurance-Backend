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
    public class PersonalInsurancesController : ControllerBase
    {
        IPersonalInsuranceService _personalInsuranceService;
        public PersonalInsurancesController(IPersonalInsuranceService personalInsuranceService)
        {
            _personalInsuranceService = personalInsuranceService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _personalInsuranceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _personalInsuranceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getallpersonalinsurancelistdto")]
        public IActionResult GetListPersonalInsuranceListDto()
        {
            var result = _personalInsuranceService.GetAllPersonalInsuranceListDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getpersonalinsurancelistdtobyid")]
        public IActionResult GetHomeInsuranceListDtoById(int id)
        {
            var result = _personalInsuranceService.GetPersonalInsuranceListDtoById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(PersonalInsurance personalInsurance)
        {
            var result = _personalInsuranceService.Add(personalInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PersonalInsurance personalInsurance)
        {
            var result = _personalInsuranceService.Delete(personalInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(PersonalInsurance personalInsurance)
        {
            var result = _personalInsuranceService.Update(personalInsurance);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
