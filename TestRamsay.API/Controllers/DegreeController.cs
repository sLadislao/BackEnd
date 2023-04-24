using System;
using Microsoft.AspNetCore.Mvc;
using TestRamsay.Bussiness.Implementations;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;

namespace TestRamsay.API.Controllers
{
    [ApiController]
    [Route("api/Degree")]
    public class DegreeController : ControllerBase
    {
        private readonly IDegreeService degreeService;
        public DegreeController(IDegreeService degreeService)
        {
            this.degreeService = degreeService;
        }

        [HttpGet]
        public List<DegreeDTO> GetAll()
        {
            return degreeService.GetAll();
        }

        [HttpGet("{id:int}")]
        public DegreeDTO GetById(int id)
        {
            return degreeService.GetById(id);
        }

        [HttpPost]
        public DegreeDTO Post(DegreeDTO degree)
        {
            return degreeService.Save(degree);
        }

        [HttpPut]
        public DegreeDTO Put(DegreeDTO degree)
        {
            return degreeService.Save(degree);
        }
        [HttpDelete("{id:int}")]
        public Boolean Delete(int id)
        {
            return degreeService.Delete(id);
        }
    }
}

