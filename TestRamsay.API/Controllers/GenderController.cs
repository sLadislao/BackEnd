using System;
using Microsoft.AspNetCore.Mvc;
using TestRamsay.Bussiness;
using TestRamsay.Bussiness.Implementations;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;
using TestRamsay.Data;
using TestRamsay.Data.Interfaces;
using TestRamsay.Data.Models;

namespace TestRamsay.API.Controllers
{
    [ApiController]
    [Route("api/Gender")]
    public class GenderController : ControllerBase
    {
        private readonly IGenderService genderService;
        public GenderController(IGenderService genderService)
        {
            this.genderService = genderService;
        }

        [HttpGet]
        public List<GenderDTO> GetAll()
        {
            return genderService.GetAll();
        }

        [HttpGet("{id:int}")]
        public GenderDTO GetById(int id)
        {
            return genderService.GetById(id);
        }

        [HttpPost]
        public GenderDTO Post(GenderDTO gender)
        {
            return genderService.Save(gender);
        }

        [HttpPut]
        public GenderDTO Put(GenderDTO gender)
        {
            return genderService.Save(gender);
        }

        [HttpDelete("{id:int}")]
        public Boolean Delete(int id)
        {
            return genderService.Delete(id);
        }
    }
}

