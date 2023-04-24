using System;
using Microsoft.AspNetCore.Mvc;
using TestRamsay.Bussiness;
using TestRamsay.Bussiness.Implementations;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;

namespace TestRamsay.API.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController
    {
        private readonly IStudentServive studentService;
        public StudentController(IStudentServive studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public List<StudentDTO> GetAll()
        {
            return studentService.GetAll();
        }

        [HttpGet("{id:int}")]
        public StudentDTO GetById(int id)
        {
            return studentService.GetById(id);
        }

        [HttpPost]
        public StudentDTO Post(StudentDTO gender)
        {
            return studentService.Save(gender);
        }

        [HttpPut]
        public StudentDTO Put(StudentDTO student)
        {
            return studentService.Save(student);
        }

        [HttpDelete("{id:int}")]
        public Boolean Delete(int id)
        {
            return studentService.Delete(id);
        }
    }
}

